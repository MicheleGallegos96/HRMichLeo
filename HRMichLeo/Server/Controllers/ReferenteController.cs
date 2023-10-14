using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferenteController : ControllerBase
    {
        
        private readonly IRepositoryBase<Referente> _referenteRepository;

        public ReferenteController(IRepositoryBase<Referente> referenteRepository)
        {
            _referenteRepository = referenteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Referente>> GetAll()
        {
            var risultato = await _referenteRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<Referente>> GetById(Guid id)
        {
            var risultato = await _referenteRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<Referente>> Post(Referente referenti)
        {
            await _referenteRepository.Create(referenti);
            return CreatedAtAction("GetById", new { id = referenti.Id }, referenti);

        }

        [HttpDelete("Delete")]

        public async Task<ActionResult<Referente>> Delete(Guid id)
        {
            await _referenteRepository.Delete(id);
            return Ok();

        }

        [HttpPut("Id")]

        public async Task<ActionResult<Referente>> Put(Guid id, Referente referenti)
        {
            if (id != referenti.Id)
            {
                return BadRequest();
            }
            await _referenteRepository.Update(referenti);
            return Ok(referenti);

        }

    }
}