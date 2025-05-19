using ApiPresidenciaDR.Application_Layer.Dlls.ScadaDlls;
using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos;
using ApiPresidenciaDR.Models.Context.ScadaContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;

namespace ApiPresidenciaDR.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Niveles6MesesAsyncController : ControllerBase
    {
        private readonly Niveles6MesesScadaDLL _nivelesDll;
        private readonly scadadbContext _context;

        public Niveles6MesesAsyncController(Niveles6MesesScadaDLL nivelesDll, scadadbContext context)
        {
            _nivelesDll = nivelesDll;
            _context = context;
        }

        [HttpGet("GetNiveles6Meses")]
        [OutputCache(Duration = 15)]
        public async Task<ActionResult<List<Niveles6MesesDto>>> GetNiveles6MesesAsync()
        {
            try
            {
                var resultado = await _context.Procedures.GetNiveles6mesesAsync();
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
    }
}
