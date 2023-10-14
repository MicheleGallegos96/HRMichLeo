using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    public class LivelloContrattualeController : Controller
    {
        
        private readonly IRepositoryBase<LivelloContrattuale> _livelloContrattualeRepository;

        public LivelloContrattualeController(IRepositoryBase<LivelloContrattuale> livelloContrattualeRepository)
        {
            _livelloContrattualeRepository = livelloContrattualeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<LivelloContrattuale>> GetAll()
        {
            var risultato = await _livelloContrattualeRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<LivelloContrattuale>> GetById(Guid id)
        {
            var risultato = await _livelloContrattualeRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<LivelloContrattuale>> Post(LivelloContrattuale livelliContrattuale)
        {
            await _livelloContrattualeRepository.Create(livelliContrattuale);
            return CreatedAtAction("GetById", new { id = livelliContrattuale.Id }, livelliContrattuale);

        }

        [HttpDelete("Delete")]

        public async Task<ActionResult<LivelloContrattuale>> Delete(Guid id)
        {
            await _livelloContrattualeRepository.Delete(id);
            return Ok();

        }

        [HttpPut("Id")]

        public async Task<ActionResult<LivelloContrattuale>> Put(Guid id, LivelloContrattuale livelliContrattuale)
        {
            if (id != livelliContrattuale.Id)
            {
                return BadRequest();
            }
            await _livelloContrattualeRepository.Update(livelliContrattuale);
            return Ok(livelliContrattuale);

        }

    }
}
