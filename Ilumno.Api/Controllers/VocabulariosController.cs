using AutoMapper;
using Ilumno.Api.Controllers.Dtos.Pais;
using Ilumno.Api.Controllers.Dtos.TipoDocumento;
using Ilumno.Core.Common.Data;
using Ilumno.Core.Common.Exceptions;
using Ilumno.Core.Paises.Services;
using Ilumno.Core.TiposDocumentos.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ilumno.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VocabulariosController(IPaisService paisService,
                                        ITipoDocumentoService tipoDocumentoService,
                                        IMapper mapper,
                                        IUnitOfWork unitOfWork) : Controller
    {
        private IPaisService PaisService { get; } = paisService;
        private ITipoDocumentoService TipoDocumentoService { get; } = tipoDocumentoService;
        private IMapper Mapper { get; } = mapper;
        private IUnitOfWork UnitOfWork { get; } = unitOfWork;

        [HttpGet]
        [Route("paises")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<PaisDto>>> GetAllPaises()
        {
            try
            {
                var paisesDto = (await PaisService.GetAll())
                    .Select(x => Mapper.Map<PaisDto>(x))
                    .OrderBy(p => p.Id);

                return Ok(paisesDto);
            }
            catch (NotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("TipoDocumentos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<TipoDocumentoDto>>> GetAllTipoDocumentos()
        {
            try
            {
                var tipoDocumentos = await TipoDocumentoService.GetAll();
                var tipoDocumentoDto = tipoDocumentos.Select(x => Mapper.Map<TipoDocumentoDto>(x));

                return Ok(tipoDocumentoDto);
            }
            catch (NotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
