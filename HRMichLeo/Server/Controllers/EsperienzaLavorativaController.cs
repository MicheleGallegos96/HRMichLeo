using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EsperienzaLavorativaController : ControllerBase
    {
        private readonly IRepositoryBase<EsperienzaLavorativa> _esperienzeLavorativaRepository;

        public EsperienzaLavorativaController(IRepositoryBase<EsperienzaLavorativa> esperienzaLavorativaRepository)
        {
            _esperienzeLavorativaRepository = esperienzaLavorativaRepository;
        }

        [HttpGet]
        public async Task<ActionResult<EsperienzaLavorativa>> GetAll()
        {
            var risultato = await _esperienzeLavorativaRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<EsperienzaLavorativa>> GetById(Guid id)
        {
            var risultato = await _esperienzeLavorativaRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<EsperienzaLavorativa>> Post(EsperienzaLavorativa lavoro)
        {
            await _esperienzeLavorativaRepository.Create(lavoro);
            return CreatedAtAction("GetById", new { id = lavoro.Id }, lavoro);

        }

        [HttpDelete("Delete")]

        public async Task<ActionResult<EsperienzaLavorativa>> Delete(Guid id)
        {
            await _esperienzeLavorativaRepository.Delete(id);
            return Ok();

        }

        [HttpPut("Id")]

        public async Task<ActionResult<EsperienzaLavorativa>> Put(Guid id, EsperienzaLavorativa esperienzaLavorativa)
        {
            if (id != esperienzaLavorativa.Id)
            {
                return BadRequest();
            }
            await _esperienzeLavorativaRepository.Update(esperienzaLavorativa);
            return Ok(esperienzaLavorativa);

        }

    }
}

