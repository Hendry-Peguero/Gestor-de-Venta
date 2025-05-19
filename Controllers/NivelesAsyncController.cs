using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiPresidenciaDR.Models.Context.ScadaContext;
using Microsoft.AspNetCore.Authorization;
using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos;
using ApiPresidenciaDR.Infrastructure_Layer.Data_Access.Models.CommonModels;
using Microsoft.AspNetCore.OutputCaching;
using ApiPresidenciaDR.Application_Layer.Dtos.ScadaDtos.UltimosNiveles;

namespace ApiPresidenciaDR.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NivelesAsyncController : ControllerBase
    {
        private readonly scadadbContext _context;
        private readonly IScadaRepository _repository;
        private readonly NivelesScadaDLL _nivelesDll;

        public NivelesAsyncController(IScadaRepository context, NivelesScadaDLL nivelesDll, scadadbContext contexts)
        {
            _repository = context;
            _nivelesDll = nivelesDll;
            _context = contexts;
        }

        //GET: api/NivelesAsync
        [HttpGet("GetNivelesAsync")]
        [OutputCache(Duration = 15)]
        public async Task<ActionResult<List<NivelesDto>>> GetPotencia5MinutosAsync()
        {
            if (_repository == null)
            {
                return NotFound();
            }
            return Ok(await _nivelesDll.NivelCentrales5minutosAsync());
        }


        [HttpGet("GetUltimosNiveles")]
        public async Task<ActionResult<IEnumerable<GetUltimosNivelesResult>>> GetUltimosNiveles()
        {
            try
            {
                var resultado = await _context.Procedures.UltimosNiveleCentralessAsync();
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }


    }
}
