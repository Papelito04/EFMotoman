using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{
    [Route("api/inventario")]
    [ApiController]
    public class InventarioController : ControllerBase
    {
        private readonly ILogger<InventarioController> _logger;
        private readonly IInventarioRepository _inventariorepo;
        private readonly IMapper _mapper;

        public InventarioController(ILogger<InventarioController> logger, IInventarioRepository inventariorepo, IMapper mapper)
        {
            _logger = logger;
            _inventariorepo = inventariorepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<InventarioDto>>> GetInventarios()
        {
            _logger.LogInformation("Obtener las inventarios");

            var InventarioList = await _inventariorepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<InventarioDto>>(InventarioList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetInventario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InventarioDto>> GetInventario(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Inventario con Id {id}");
                return BadRequest();
            }
            var catego = await _inventariorepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<InventarioDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateInventario(int id, [FromBody] InventarioDto InventarioUpdateDto)
        {
            if (InventarioUpdateDto == null || id != InventarioUpdateDto.Id)
            {
                return BadRequest();
            }

            Inventario modelo = _mapper.Map<Inventario>(InventarioUpdateDto);



            await _inventariorepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialInventario(int id, JsonPatchDocument<InventarioUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Inventario = await _inventariorepo.Get(s => s.Id == id, tracked: false);

            InventarioUpdateDto InventarioUpdateDto = _mapper.Map<InventarioUpdateDto>(Inventario);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Inventario == null) return BadRequest();

            patchDto.ApplyTo(InventarioUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Inventario modelo = _mapper.Map<Inventario>(InventarioUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _inventariorepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<InventarioDto>> AddInventario([FromBody] InventarioCreateDto inventarioCreateDto)
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


            if (inventarioCreateDto == null)
            {
                return BadRequest(inventarioCreateDto);
            }

            Inventario modelo = _mapper.Map<Inventario>(inventarioCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _inventariorepo.Add(modelo);

            return CreatedAtRoute("GetInventario", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteInventario(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _inventariorepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _inventariorepo.Remove(catego);

            return NoContent();
        }

    }
}
