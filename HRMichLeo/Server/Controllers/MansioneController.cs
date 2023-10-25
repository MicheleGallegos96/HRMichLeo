using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MansioneController : ControllerBase
    {
        
        private readonly IRepositoryBase<Mansione> _mansioneRepository;

        public MansioneController(IRepositoryBase<Mansione> mansioneRepository)
        {
            _mansioneRepository = mansioneRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Mansione>> GetAll()
        {
            var risultato = await _mansioneRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("{Id:guid}")]
        public async Task<ActionResult<Mansione>> GetById(Guid id)
        {
            var risultato = await _mansioneRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("{id:guid}")]

        public async Task<ActionResult<Mansione>> Post(Mansione mansioni)
        {
            await _mansioneRepository.Create(mansioni);
            return CreatedAtAction("GetById", new { id = mansioni.Id }, mansioni);

        }

        [HttpDelete("{id:guid}")]

        public async Task<ActionResult<Mansione>> Delete(Guid id)
        {
            await _mansioneRepository.Delete(id);
            return Ok();

        }

        [HttpPut("{Id:guid}")]

        public async Task<ActionResult<Mansione>> Put(Guid id, Mansione mansioni)
        {
            if (id != mansioni.Id)
            {
                return BadRequest();
            }
            await _mansioneRepository.Update(mansioni);
            return Ok(mansioni);

        }

    }
}
    
