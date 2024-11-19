using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{
    [Route("api/persona")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ILogger<PersonaController> _logger;
        private readonly IPersonaRepository _personarepo;
        private readonly IMapper _mapper;

        public PersonaController(ILogger<PersonaController> logger, IPersonaRepository personarepo, IMapper mapper)
        {
            _logger = logger;
            _personarepo = personarepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<PersonaDto>>> GetPersonas()
        {
            _logger.LogInformation("Obtener las personas");

            var PersonaList = await _personarepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<PersonaDto>>(PersonaList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetPersona")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PersonaDto>> GetPersona(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Persona con Id {id}");
                return BadRequest();
            }
            var catego = await _personarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PersonaDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePersona(int id, [FromBody] PersonaDto PersonaUpdateDto)
        {
            if (PersonaUpdateDto == null || id != PersonaUpdateDto.Id)
            {
                return BadRequest();
            }

            Persona modelo = _mapper.Map<Persona>(PersonaUpdateDto);



            await _personarepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialPersona(int id, JsonPatchDocument<PersonaUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Persona = await _personarepo.Get(s => s.Id == id, tracked: false);

            PersonaUpdateDto PersonaUpdateDto = _mapper.Map<PersonaUpdateDto>(Persona);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Persona == null) return BadRequest();

            patchDto.ApplyTo(PersonaUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Persona modelo = _mapper.Map<Persona>(PersonaUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _personarepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PersonaDto>> AddPersona([FromBody] PersonaCreateDto personaCreateDto)
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


            if (personaCreateDto == null)
            {
                return BadRequest(personaCreateDto);
            }

            Persona modelo = _mapper.Map<Persona>(personaCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _personarepo.Add(modelo);

            return CreatedAtRoute("GetPersona", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeletePersona(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _personarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _personarepo.Remove(catego);

            return NoContent();
        }

    }
}
