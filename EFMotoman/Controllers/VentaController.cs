using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{
    [Route("api/venta")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly ILogger<VentaController> _logger;
        private readonly IVentaRepository _ventarepo;
        private readonly IMapper _mapper;

        public VentaController(ILogger<VentaController> logger, IVentaRepository ventarepo, IMapper mapper)
        {
            _logger = logger;
            _ventarepo = ventarepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<VentaDto>>> GetVentas()
        {
            _logger.LogInformation("Obtener las ventas");

            var VentaList = await _ventarepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<VentaDto>>(VentaList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetVenta")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VentaDto>> GetVenta(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Venta con Id {id}");
                return BadRequest();
            }
            var catego = await _ventarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<VentaDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateVenta(int id, [FromBody] VentaDto VentaUpdateDto)
        {
            if (VentaUpdateDto == null || id != VentaUpdateDto.Id)
            {
                return BadRequest();
            }

            Venta modelo = _mapper.Map<Venta>(VentaUpdateDto);



            await _ventarepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVenta(int id, JsonPatchDocument<VentasUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Venta = await _ventarepo.Get(s => s.Id == id, tracked: false);

            VentasUpdateDto ventaUpdateDto = _mapper.Map<VentasUpdateDto>(Venta);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Venta == null) return BadRequest();

            patchDto.ApplyTo(ventaUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Venta modelo = _mapper.Map<Venta>(ventaUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _ventarepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VentaDto>> AddVenta([FromBody] VentaCreateDto ventaCreateDto)
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


            if (ventaCreateDto == null)
            {
                return BadRequest(ventaCreateDto);
            }

            Venta modelo = _mapper.Map<Venta>(ventaCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _ventarepo.Add(modelo);

            return CreatedAtRoute("GetVenta", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVenta(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _ventarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _ventarepo.Remove(catego);

            return NoContent();
        }

    }
}
