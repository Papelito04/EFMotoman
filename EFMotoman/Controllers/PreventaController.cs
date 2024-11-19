using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{

    [Route("api/preventa")]
    [ApiController]
    public class PreventaController : ControllerBase
    {
        private readonly ILogger<PreventaController> _logger;
        private readonly IPreventaRepository _preventarepo;
        private readonly IMapper _mapper;

        public PreventaController(ILogger<PreventaController> logger, IPreventaRepository preventarepo, IMapper mapper)
        {
            _logger = logger;
            _preventarepo = preventarepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PreventaDto>>> GetPreventas()
        {
            _logger.LogInformation("Obtener las preventas");

            var PreventaList = await _preventarepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<PreventaDto>>(PreventaList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetPreventa")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PreventaDto>> GetPreventa(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Preventa con Id {id}");
                return BadRequest();
            }
            var catego = await _preventarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PreventaDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePreventa(int id, [FromBody] PreventaDto PreventaUpdateDto)
        {
            if (PreventaUpdateDto == null || id != PreventaUpdateDto.Id)
            {
                return BadRequest();
            }

            Preventa modelo = _mapper.Map<Preventa>(PreventaUpdateDto);



            await _preventarepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialPreventa(int id, JsonPatchDocument<PreventaUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Preventa = await _preventarepo.Get(s => s.Id == id, tracked: false);

            PreventaUpdateDto PreventaUpdateDto = _mapper.Map<PreventaUpdateDto>(Preventa);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Preventa == null) return BadRequest();

            patchDto.ApplyTo(PreventaUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Preventa modelo = _mapper.Map<Preventa>(PreventaUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _preventarepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PreventaDto>> AddPreventa([FromBody] PreventaCreateDto preventaCreateDto)
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


            if (preventaCreateDto == null)
            {
                return BadRequest(preventaCreateDto);
            }

            Preventa modelo = _mapper.Map<Preventa>(preventaCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _preventarepo.Add(modelo);

            return CreatedAtRoute("GetPreventa", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeletePreventa(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _preventarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _preventarepo.Remove(catego);

            return NoContent();
        }

    }
}
