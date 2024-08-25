using AutoMapper;
using Ilumno.Api.Controllers.Dtos.Formulario;
using Ilumno.Core.Common.Data;
using Ilumno.Core.Common.Exceptions;
using Ilumno.Core.Formularios.Models;
using Ilumno.Core.Formularios.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ilumno.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController(IFormularioService formularioService, IMapper mapper, IUnitOfWork unitOfWork) : Controller
    {
        private IFormularioService FormularioService { get; } = formularioService;
        private IMapper Mapper { get; } = mapper;
        private IUnitOfWork UnitOfWork { get; } = unitOfWork;

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<FormularioDto>> Create([FromBody] CreateFormularioDto createFormularioDto)
        {
            try
            {
                var formulario = Mapper.Map<Formulario>(createFormularioDto);
                await FormularioService.Add(formulario);

                await UnitOfWork.CommitAsync();
                var formularioDto = Mapper.Map<FormularioDto>(formulario);

                return CreatedAtAction(nameof(Create), new { id = formulario.Id }, formularioDto);

            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("data")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<FormularioResponseDto>>> GetAll()
        {
            try
            {
                var formularios = Mapper.Map<List<FormularioResponseDto>>(await FormularioService.GetAll());
                return Ok(formularios);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
