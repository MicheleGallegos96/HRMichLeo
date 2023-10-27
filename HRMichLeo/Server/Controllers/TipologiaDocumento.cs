using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipologiaDocumentoController : ControllerBase
    {
        private readonly IRepositoryBase<TipologiaDocumento> _tipologiaDocumentoRepository;

        public TipologiaDocumentoController(IRepositoryBase<TipologiaDocumento> tipologiaDocumentoRepository)
        {
            _tipologiaDocumentoRepository = tipologiaDocumentoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<TipologiaDocumento>> GetAll()
        {
            var risultato = await _tipologiaDocumentoRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<TipologiaDocumento>> GetById(Guid id)
        {
            var risultato = await _tipologiaDocumentoRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<TipologiaDocumento>> Post(TipologiaDocumento tipologiaDocumento)
        {
            await _tipologiaDocumentoRepository.Create(tipologiaDocumento);
            return CreatedAtAction("GetById", new { id = tipologiaDocumento.Id }, tipologiaDocumento);

        }

        [HttpDelete("{id:guid}")]

        public async Task<ActionResult<TipologiaDocumento>> Delete(Guid id)
        {
            await _tipologiaDocumentoRepository.Delete(id);
            return Ok();

        }

        [HttpPut("{id:guid}")]

        public async Task<ActionResult<TipologiaDocumento>> Put(Guid id, TipologiaDocumento tipologiaDocumento)
        {
            if (id != tipologiaDocumento.Id)
            {
                return BadRequest();
            }
            await _tipologiaDocumentoRepository.Update(tipologiaDocumento);
            return Ok(tipologiaDocumento);

        }

    }
}
