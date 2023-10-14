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

        [HttpGet("Id")]
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

        [HttpDelete("Delete")]

        public async Task<ActionResult<TipologiaContratto>> Delete(Guid id)
        {
            await _tipologiaContrattoRepository.Delete(id);
            return Ok();

        }

        [HttpPut("Id")]

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


