using AutoMapper;
using EFMotoman.Models;
using EFMotoman.Models.Dto;
using EFMotoman.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace EFMotoman.Controllers
{
    //esto no va por que EF hizo que en personas estuvieran los datos de empleado...
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        
            private readonly ILogger<EmpleadoController> _logger;
            private readonly IEmpleadoRepository _empleadoRepo;
            private readonly IMapper _mapper;
            public EmpleadoController(ILogger<EmpleadoController> logger, IEmpleadoRepository empleadoRepo, IMapper mapper)
            {
                _logger = logger;
                _empleadoRepo = empleadoRepo;
                _mapper = mapper;
            }


            [HttpGet]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult<IEnumerable<EmpleadoDto>>> GetEmpleados()
            {
                _logger.LogInformation("Obtener las Empleados");

                var EmpleadoList = await _empleadoRepo.GetAll();

                return Ok(_mapper.Map<IEnumerable<EmpleadoDto>>(EmpleadoList));
            }

            // GET: api/Empleado/5
            [HttpGet("{id:int}", Name = "GetEmpleado")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<ActionResult<EmpleadoDto>> GetEmpleado(int id)
            {
                if (id == 0)
                {
                    _logger.LogError($"Error al traer Empleado con Id {id}");
                    return BadRequest();
                }
                var obr = await _empleadoRepo.Get(a => a.Id == id);

                if (obr == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<EmpleadoDto>(obr));
            }

            // PUT: api/Empleado/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id:int}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<IActionResult> UpdateEmpleado(int id, [FromBody] EmpleadoUpdateDto EmpleadoUpdateDto)
            {
                if (EmpleadoUpdateDto == null || id != EmpleadoUpdateDto.Id)
                {
                    return BadRequest();
                }

                Empleado modelo = _mapper.Map<Empleado>(EmpleadoUpdateDto);

                //Empleado modelo = new()
                //{
                //    EmpleadoId = EmpleadoUpdateDto.EmpleadoId,
                //    EmpleadoName = EmpleadoUpdateDto.EmpleadoName
                //};

                await _empleadoRepo.Update(modelo);

                return NoContent();
            }

            [HttpPatch("{id:int}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<IActionResult> UpdatePartialEmpleado(int id, JsonPatchDocument<EmpleadoUpdateDto> patchDto)
            {
                if (patchDto == null || id == 0)
                {
                    return BadRequest();
                }

                var Empleado = await _empleadoRepo.Get(s => s.Id == id, tracked: false);

                EmpleadoUpdateDto EmpleadoUpdateDto = _mapper.Map<EmpleadoUpdateDto>(Empleado);
                //EmpleadoUpdateDto EmpleadoUpdateDto = new()
                //{
                //    EmpleadoId = Empleado.EmpleadoId,
                //    EmpleadoName = Empleado.EmpleadoName
                //};
                if (Empleado == null) return BadRequest();

                patchDto.ApplyTo(EmpleadoUpdateDto, ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                Empleado modelo = _mapper.Map<Empleado>(EmpleadoUpdateDto);
                //Empleado modelo = new()
                //{
                //    EmpleadoId = EmpleadoUpdateDto.EmpleadoId,
                //    EmpleadoName = EmpleadoUpdateDto.EmpleadoName
                //};
                await _empleadoRepo.Update(modelo);

                return NoContent();
            }

            // POST: api/Empleado
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            [ProducesResponseType(StatusCodes.Status201Created)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<ActionResult<EmpleadoDto>> AddStudent([FromBody] EmpleadoCreateDto empleadoCreateDto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }



                if (empleadoCreateDto == null)
                {
                    return BadRequest(empleadoCreateDto);
                }

                Empleado modelo = _mapper.Map<Empleado>(empleadoCreateDto);

                //Student modelo = new()
                //{
                //    StudentName = EmpleadoCreateDto.StudentName
                //};

                await _empleadoRepo.Add(modelo);

                return CreatedAtRoute("GetEmpleado", new { id = modelo.Id }, modelo);


            }


            //********************************************************************************************************************************
            //ESTO SOLO ES PRUEBASSSSSSS---------------------------------------------------------------------------------//

            //********************************************************************************************************************************



            // DELETE: api/Empleado/5
            [HttpDelete("{id:int}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<IActionResult> DeleteEmpleado(int id)
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var obr = await _empleadoRepo.Get(a => a.Id == id);

                if (obr == null)
                {
                    return NotFound();
                }

                await _empleadoRepo.Remove(obr);

                return NoContent();
            }

        
    }
}
