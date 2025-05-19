using Microsoft.AspNetCore.Mvc;
using ApiPresidenciaDR.Models.Context.ScadaContext;
using Microsoft.AspNetCore.Authorization;

namespace ApiPresidenciaDR.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class Generacion24hAsyncController : ControllerBase
    {
        private readonly scadadbContext _context;

        public Generacion24hAsyncController(scadadbContext context)
        {
            _context = context;
        }

        [HttpGet("GetGeneracion24h")]
        public async Task<ActionResult<IEnumerable<GetGeneracionUltimas24HorasResult>>> GetGeneracion24h()
        {
            try
            {
                var resultado = await _context.Procedures.GetGeneracionUltimas24HorasAsync(); // <-- CORRECTO
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
    }
}
