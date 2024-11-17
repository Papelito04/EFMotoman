using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{
    public class FacturaController : ControllerBase
    {
        private readonly ILogger<FacturaController> _logger;
        private readonly IFacturaRepository _facturarepo;
        private readonly IMapper _mapper;

        public FacturaController(ILogger<FacturaController> logger, IFacturaRepository facturarepo, IMapper mapper)
        {
            _logger = logger;
            _facturarepo = facturarepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<FacturaDto>>> GetFacturas()
        {
            _logger.LogInformation("Obtener las facturas");

            var FacturaList = await _facturarepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<FacturaDto>>(FacturaList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetFactura")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FacturaDto>> GetFactura(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Factura con Id {id}");
                return BadRequest();
            }
            var catego = await _facturarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<FacturaDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateFactura(int id, [FromBody] FacturaDto FacturaUpdateDto)
        {
            if (FacturaUpdateDto == null || id != FacturaUpdateDto.Id)
            {
                return BadRequest();
            }

            Factura modelo = _mapper.Map<Factura>(FacturaUpdateDto);



            await _facturarepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialFactura(int id, JsonPatchDocument<FacturaUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Factura = await _facturarepo.Get(s => s.Id == id, tracked: false);

            FacturaUpdateDto FacturaUpdateDto = _mapper.Map<FacturaUpdateDto>(Factura);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Factura == null) return BadRequest();

            patchDto.ApplyTo(FacturaUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Factura modelo = _mapper.Map<Factura>(FacturaUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _facturarepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<FacturaDto>> AddFactura([FromBody] FacturaCreateDto facturaCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (await _autorRepo.Get(s => s.StudentName.ToLower() == AutorCreateDto.StudentName.ToLower()) != null)
            //{
            //    ModelState.AddModelError("NombreExiste", "¡El Estudiante con ese Nombre ya existe!");
            //    return BadRequest(ModelState);
            //}


            if (facturaCreateDto == null)
            {
                return BadRequest(facturaCreateDto);
            }

            Factura modelo = _mapper.Map<Factura>(facturaCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _facturarepo.Add(modelo);

            return CreatedAtRoute("GetFactura", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteFactura(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _facturarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _facturarepo.Remove(catego);

            return NoContent();
        }
    }
}
