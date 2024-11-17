using AutoMapper;
using EFMotoman.Models;
using EFMotoman.Models.Dto;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{
    //NO SE SI FALTA UN GLOBAL CONTROLLER++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ILogger<CategoriaController> _logger;
        private readonly ICategoriaRepository _categoriarepo;
        private readonly IMapper _mapper;

        public CategoriaController(ILogger<CategoriaController> logger, ICategoriaRepository categoriarepo, IMapper mapper)
        {
            _logger = logger;
            _categoriarepo = categoriarepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CategoriaDto>>> GetCategorias()
        {
            _logger.LogInformation("Obtener las categorias");

            var CategoriaList = await _categoriarepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<CategoriaDto>>(CategoriaList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetCategoria")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoriaDto>> GetCategoria(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Categoria con Id {id}");
                return BadRequest();
            }
            var catego = await _categoriarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CategoriaDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCategoria(int id, [FromBody] CategoriaDto CategoriaUpdateDto)
        {
            if (CategoriaUpdateDto == null || id != CategoriaUpdateDto.Id)
            {
                return BadRequest();
            }

            Categoria modelo = _mapper.Map<Categoria>(CategoriaUpdateDto);

           

            await _categoriarepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialCategoria(int id, JsonPatchDocument<CategoriaUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Categoria = await _categoriarepo.Get(s => s.Id == id, tracked: false);

            CategoriaUpdateDto CategoriaUpdateDto = _mapper.Map<CategoriaUpdateDto>(Categoria);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Categoria == null) return BadRequest();

            patchDto.ApplyTo(CategoriaUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Categoria modelo = _mapper.Map<Categoria>(CategoriaUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _categoriarepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CategoriaDto>> AddCategoria([FromBody] CategoriaCreateDto categoriaCreateDto)
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


            if (categoriaCreateDto == null)
            {
                return BadRequest(categoriaCreateDto);
            }

            Categoria modelo = _mapper.Map<Categoria>(categoriaCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _categoriarepo.Add(modelo);

            return CreatedAtRoute("GetCategoria", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCategoria(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _categoriarepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _categoriarepo.Remove(catego);

            return NoContent();
        }


    }
}
