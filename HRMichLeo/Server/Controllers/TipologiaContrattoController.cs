using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipologiaContrattoController : ControllerBase
    {

        private readonly IRepositoryBase<TipologiaContratto> _tipologiaContrattoRepository;

        public TipologiaContrattoController(IRepositoryBase<TipologiaContratto> tipologiaContrattoRepository)
        {
            _tipologiaContrattoRepository = tipologiaContrattoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<TipologiaContratto>> GetAll()
        {
            var risultato = await _tipologiaContrattoRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<TipologiaContratto>> GetById(Guid id)
        {
            var risultato = await _tipologiaContrattoRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<TipologiaContratto>> Post(TipologiaContratto tipologiaContratto)
        {
            await _tipologiaContrattoRepository.Create(tipologiaContratto);
            return CreatedAtAction("GetById", new { id = tipologiaContratto.Id }, tipologiaContratto);

        }

        [HttpDelete("{id:guid}")]

        public async Task<ActionResult<TipologiaContratto>> Delete(Guid id)
        {
            await _tipologiaContrattoRepository.Delete(id);
            return Ok();

        }

        [HttpPut("{id:guid}")]

        public async Task<ActionResult<TipologiaContratto>> Put(Guid id, TipologiaContratto tipologiaContratto)
        {
            if (id != tipologiaContratto.Id)
            {
                return BadRequest();
            }
            await _tipologiaContrattoRepository.Update(tipologiaContratto);
            return Ok(tipologiaContratto);

        }

    }
}


