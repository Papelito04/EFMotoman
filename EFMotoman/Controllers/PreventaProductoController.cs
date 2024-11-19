using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{

    [Route("api/preventaproducto")]
    [ApiController]
    public class PreventaProductoController : ControllerBase
    {
        private readonly ILogger<PreventaProductoController> _logger;
        private readonly IPreventaProductoRepository _preventaProductorepo;
        private readonly IMapper _mapper;

        public PreventaProductoController(ILogger<PreventaProductoController> logger, IPreventaProductoRepository preventaProductorepo, IMapper mapper)
        {
            _logger = logger;
            _preventaProductorepo = preventaProductorepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PreventaProductoDto>>> GetPreventaProductos()
        {
            _logger.LogInformation("Obtener las preventaProductos");

            var PreventaProductoList = await _preventaProductorepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<PreventaProductoDto>>(PreventaProductoList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetPreventaProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PreventaProductoDto>> GetPreventaProducto(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer PreventaProducto con Id {id}");
                return BadRequest();
            }
            var catego = await _preventaProductorepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PreventaProductoDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePreventaProducto(int id, [FromBody] PreventaProductoDto PreventaProductoUpdateDto)
        {
            if (PreventaProductoUpdateDto == null || id != PreventaProductoUpdateDto.Id)
            {
                return BadRequest();
            }

            PreventaProducto modelo = _mapper.Map<PreventaProducto>(PreventaProductoUpdateDto);



            await _preventaProductorepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialPreventaProducto(int id, JsonPatchDocument<PreventaProductoUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var PreventaProducto = await _preventaProductorepo.Get(s => s.Id == id, tracked: false);

            PreventaProductoUpdateDto PreventaProductoUpdateDto = _mapper.Map<PreventaProductoUpdateDto>(PreventaProducto);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (PreventaProducto == null) return BadRequest();

            patchDto.ApplyTo(PreventaProductoUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            PreventaProducto modelo = _mapper.Map<PreventaProducto>(PreventaProductoUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _preventaProductorepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PreventaProductoDto>> AddPreventaProducto([FromBody] PreventaProductoCreateDto preventaProductoCreateDto)
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


            if (preventaProductoCreateDto == null)
            {
                return BadRequest(preventaProductoCreateDto);
            }

            PreventaProducto modelo = _mapper.Map<PreventaProducto>(preventaProductoCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _preventaProductorepo.Add(modelo);

            return CreatedAtRoute("GetPreventaProducto", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeletePreventaProducto(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _preventaProductorepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _preventaProductorepo.Remove(catego);

            return NoContent();
        }

    }
}
