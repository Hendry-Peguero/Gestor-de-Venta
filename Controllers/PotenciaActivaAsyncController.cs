using ApiPresidenciaDR.Application_Layer.Dtos;
using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos;
using ApiPresidenciaDR.Infrastructure_Layer.Data_Access.Models.CommonModels;
using ApiPresidenciaDR.Models.Context.ScadaContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using System.ComponentModel.DataAnnotations;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiPresidenciaDR.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PotenciaActivaAsyncController : ControllerBase
    {
        private readonly IScadaRepository _repository;
        private readonly PotenciaUltimas24HorasScadaDLL _potenciaScadaDLL;

        public PotenciaActivaAsyncController(IScadaRepository repository, PotenciaUltimas24HorasScadaDLL potenciaScadaDLL)
        {
            _repository = repository;
            _potenciaScadaDLL = potenciaScadaDLL;
        }

        // GET: trae el ultimo nivel de embalse registrado por central cada 5 Minutos.

        [HttpGet("GetPotenciaAsync")]
        [OutputCache(Duration = 15)]
        public async Task<ActionResult<List<PotenciaDto>>> PotenciaActiva5MinutoAsync()
        {
            //throw new Exception("Text exection");
            if (_repository == null)
            {
                return NotFound();
            }

            return Ok(await _potenciaScadaDLL.PotenciaActiva5MinutoAsync());
        }


        [HttpOptions]
        public IActionResult GetNivelesOptions()
        {
            Response.Headers.Add("Allow", "GET, OPTIONS");
            return Ok();    

        }

    }
}
