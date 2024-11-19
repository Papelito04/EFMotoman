using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{

    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioRepository _usuariorepo;
        private readonly IMapper _mapper;

        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioRepository usuariorepo, IMapper mapper)
        {
            _logger = logger;
            _usuariorepo = usuariorepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetUsuarios()
        {
            _logger.LogInformation("Obtener las usuarios");

            var UsuarioList = await _usuariorepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<UsuarioDto>>(UsuarioList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetUsuario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UsuarioDto>> GetUsuario(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Usuario con Id {id}");
                return BadRequest();
            }
            var catego = await _usuariorepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UsuarioDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateUsuario(int id, [FromBody] UsuarioDto UsuarioUpdateDto)
        {
            if (UsuarioUpdateDto == null || id != UsuarioUpdateDto.Id)
            {
                return BadRequest();
            }

            Usuario modelo = _mapper.Map<Usuario>(UsuarioUpdateDto);



            await _usuariorepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialUsuario(int id, JsonPatchDocument<UsuarioUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Usuario = await _usuariorepo.Get(s => s.Id == id, tracked: false);

            UsuarioUpdateDto UsuarioUpdateDto = _mapper.Map<UsuarioUpdateDto>(Usuario);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Usuario == null) return BadRequest();

            patchDto.ApplyTo(UsuarioUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Usuario modelo = _mapper.Map<Usuario>(UsuarioUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _usuariorepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UsuarioDto>> AddUsuario([FromBody] UsuarioCreateDto usuarioCreateDto)
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


            if (usuarioCreateDto == null)
            {
                return BadRequest(usuarioCreateDto);
            }

            Usuario modelo = _mapper.Map<Usuario>(usuarioCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _usuariorepo.Add(modelo);

            return CreatedAtRoute("GetUsuario", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _usuariorepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _usuariorepo.Remove(catego);

            return NoContent();
        }

    }
}
