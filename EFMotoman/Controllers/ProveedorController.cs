using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{
    public class ProveedorController : ControllerBase
    {
        private readonly ILogger<ProveedorController> _logger;
        private readonly IProveedorRepository _proveedorrepo;
        private readonly IMapper _mapper;

        public ProveedorController(ILogger<ProveedorController> logger, IProveedorRepository proveedorrepo, IMapper mapper)
        {
            _logger = logger;
            _proveedorrepo = proveedorrepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProveedorDto>>> GetProveedors()
        {
            _logger.LogInformation("Obtener las proveedors");

            var ProveedorList = await _proveedorrepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProveedorDto>>(ProveedorList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetProveedor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProveedorDto>> GetProveedor(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Proveedor con Id {id}");
                return BadRequest();
            }
            var catego = await _proveedorrepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProveedorDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProveedor(int id, [FromBody] ProveedorDto ProveedorUpdateDto)
        {
            if (ProveedorUpdateDto == null || id != ProveedorUpdateDto.Id)
            {
                return BadRequest();
            }

            Proveedor modelo = _mapper.Map<Proveedor>(ProveedorUpdateDto);



            await _proveedorrepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialProveedor(int id, JsonPatchDocument<ProveedorUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Proveedor = await _proveedorrepo.Get(s => s.Id == id, tracked: false);

            ProveedorUpdateDto ProveedorUpdateDto = _mapper.Map<ProveedorUpdateDto>(Proveedor);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Proveedor == null) return BadRequest();

            patchDto.ApplyTo(ProveedorUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Proveedor modelo = _mapper.Map<Proveedor>(ProveedorUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _proveedorrepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProveedorDto>> AddProveedor([FromBody] ProveedorCreateDto proveedorCreateDto)
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


            if (proveedorCreateDto == null)
            {
                return BadRequest(proveedorCreateDto);
            }

            Proveedor modelo = _mapper.Map<Proveedor>(proveedorCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _proveedorrepo.Add(modelo);

            return CreatedAtRoute("GetProveedor", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProveedor(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _proveedorrepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _proveedorrepo.Remove(catego);

            return NoContent();
        }

    }
}
