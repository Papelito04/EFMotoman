using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{
    public class NotificacionController : ControllerBase
    {
        private readonly ILogger<NotificacionController> _logger;
        private readonly INotificacionRepository _notificacionrepo;
        private readonly IMapper _mapper;

        public NotificacionController(ILogger<NotificacionController> logger, INotificacionRepository notificacionrepo, IMapper mapper)
        {
            _logger = logger;
            _notificacionrepo = notificacionrepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<NotificacionDto>>> GetNotificacions()
        {
            _logger.LogInformation("Obtener las notificacions");

            var NotificacionList = await _notificacionrepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<NotificacionDto>>(NotificacionList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetNotificacion")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<NotificacionDto>> GetNotificacion(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Notificacion con Id {id}");
                return BadRequest();
            }
            var catego = await _notificacionrepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<NotificacionDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateNotificacion(int id, [FromBody] NotificacionDto NotificacionUpdateDto)
        {
            if (NotificacionUpdateDto == null || id != NotificacionUpdateDto.Id)
            {
                return BadRequest();
            }

            Notificacion modelo = _mapper.Map<Notificacion>(NotificacionUpdateDto);



            await _notificacionrepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialNotificacion(int id, JsonPatchDocument<NotificacionUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Notificacion = await _notificacionrepo.Get(s => s.Id == id, tracked: false);

            NotificacionUpdateDto NotificacionUpdateDto = _mapper.Map<NotificacionUpdateDto>(Notificacion);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Notificacion == null) return BadRequest();

            patchDto.ApplyTo(NotificacionUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Notificacion modelo = _mapper.Map<Notificacion>(NotificacionUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _notificacionrepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<NotificacionDto>> AddNotificacion([FromBody] NotificacionCreateDto notificacionCreateDto)
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


            if (notificacionCreateDto == null)
            {
                return BadRequest(notificacionCreateDto);
            }

            Notificacion modelo = _mapper.Map<Notificacion>(notificacionCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _notificacionrepo.Add(modelo);

            return CreatedAtRoute("GetNotificacion", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteNotificacion(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _notificacionrepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _notificacionrepo.Remove(catego);

            return NoContent();
        }

    }
}
