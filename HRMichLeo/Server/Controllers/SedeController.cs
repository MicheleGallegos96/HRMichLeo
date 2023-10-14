using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SedeController : ControllerBase
    {
        private readonly IRepositoryBase<Sede> _sedeRepository;

        public SedeController(IRepositoryBase<Sede> sediRepository)
        {
            _sedeRepository = sediRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Sede>> GetAll()
        {
            var risultato = await _sedeRepository.GetAll();

            return Ok(risultato);
        }

        [HttpGet("id")]
        public async Task<ActionResult<Sede>> GetById(Guid id)
        {
            var risultato = await _sedeRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Sede>> Post(Sede sedi)
        {
            await _sedeRepository.Create(sedi);
            return CreatedAtAction("GetById", new { id = sedi.Id }, sedi);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<Sede>> Delete(Guid id)
        {
            await _sedeRepository.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Sede>> Put(Guid id,Sede sedi)
        {
            if (id != sedi.Id)
            {
                return BadRequest();
            }

            await _sedeRepository.Update(sedi);

            return Ok(sedi);
        }
    }
}
