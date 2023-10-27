using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenefitController : ControllerBase
    {
        private readonly IRepositoryBase<Benefit> _benefitRepository;

        public BenefitController(IRepositoryBase<Benefit> benefitRepository)
        {
            _benefitRepository = benefitRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Benefit>> GetAll()
        {
            var risultato = await _benefitRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Benefit>> GetById(Guid id)
        {
            var risultato = await _benefitRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<Benefit>> Post(Benefit benefits)
        {
            await _benefitRepository.Create(benefits);
            return CreatedAtAction("GetById", new { id = benefits.Id }, benefits);
                
        }

        [HttpDelete("{id:guid}")]

        public async Task<ActionResult<Benefit>> Delete(Guid id)
        {
             await _benefitRepository.Delete(id);
            return Ok();

        }

        [HttpPut("{id:guid}")]

        public async Task<ActionResult<Benefit>> Put(Guid id, Benefit benefits)
        {
            if (id != benefits.Id)
            {
                return BadRequest();
            }
            await _benefitRepository.Update(benefits);
            return Ok(benefits);

        }

    }
}
