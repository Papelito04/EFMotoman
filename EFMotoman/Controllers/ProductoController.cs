using AutoMapper;
using EFMotoman.Models.Dto;
using EFMotoman.Models;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{
    public class ProductoController : ControllerBase
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly IProductoRepository _productorepo;
        private readonly IMapper _mapper;

        public ProductoController(ILogger<ProductoController> logger, IProductoRepository productorepo, IMapper mapper)
        {
            _logger = logger;
            _productorepo = productorepo;
            _mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> GetProductos()
        {
            _logger.LogInformation("Obtener las productos");

            var ProductoList = await _productorepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProductoDto>>(ProductoList));
        }


        // GET: api/Autors/5
        [HttpGet("{id:int}", Name = "GetProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductoDto>> GetProducto(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Producto con Id {id}");
                return BadRequest();
            }
            var catego = await _productorepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductoDto>(catego));
        }

        // PUT: api/Autors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProducto(int id, [FromBody] ProductoDto ProductoUpdateDto)
        {
            if (ProductoUpdateDto == null || id != ProductoUpdateDto.Id)
            {
                return BadRequest();
            }

            Producto modelo = _mapper.Map<Producto>(ProductoUpdateDto);



            await _productorepo.Update(modelo);

            return NoContent();
        }


        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialProducto(int id, JsonPatchDocument<ProductoUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var Producto = await _productorepo.Get(s => s.Id == id, tracked: false);

            ProductoUpdateDto productoUpdateDto = _mapper.Map<ProductoUpdateDto>(Producto);
            //AutorUpdateDto AutorUpdateDto = new()
            //{
            //    AutorId = Autor.AutorId,
            //    AutorName = Autor.AutorName
            //};
            if (Producto == null) return BadRequest();

            patchDto.ApplyTo(productoUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Producto modelo = _mapper.Map<Producto>(productoUpdateDto);
            //Autor modelo = new()
            //{
            //    AutorId = AutorUpdateDto.AutorId,
            //    AutorName = AutorUpdateDto.AutorName
            //};
            await _productorepo.Update(modelo);

            return NoContent();
        }


        // POST: api/Autors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductoDto>> AddProducto([FromBody] ProductoCreateDto productoCreateDto)
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


            if (productoCreateDto == null)
            {
                return BadRequest(productoCreateDto);
            }

            Producto modelo = _mapper.Map<Producto>(productoCreateDto);

            //Student modelo = new()
            //{
            //    StudentName = AutorCreateDto.StudentName
            //};

            await _productorepo.Add(modelo);

            return CreatedAtRoute("GetProducto", new { id = modelo.Id }, modelo);


        }


        // DELETE: api/Autors/5
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var catego = await _productorepo.Get(c => c.Id == id);

            if (catego == null)
            {
                return NotFound();
            }

            await _productorepo.Remove(catego);

            return NoContent();
        }

    }
}
