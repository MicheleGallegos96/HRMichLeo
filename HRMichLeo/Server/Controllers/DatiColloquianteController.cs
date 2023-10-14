using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatiColloquianteController : ControllerBase
    {
        
        private readonly IRepositoryBase<DatiColloquiante> _datiColloquianteRepository;

        public DatiColloquianteController(IRepositoryBase<DatiColloquiante> datiColloquianteRepository)
        {
            _datiColloquianteRepository = datiColloquianteRepository;
        }

        [HttpGet]
        public async Task<ActionResult<DatiColloquiante>> GetAll()
        {
            var risultato = await _datiColloquianteRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<DatiColloquiante>> GetById(Guid id)
        {
            var risultato = await _datiColloquianteRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<DatiColloquiante>> Post(DatiColloquiante colloquiante)
        {
            await _datiColloquianteRepository.Create(colloquiante);
            return CreatedAtAction("GetById", new { id = colloquiante.Id }, colloquiante);

        }

        [HttpDelete("Delete")]

        public async Task<ActionResult<DatiColloquiante>> Delete(Guid id)
        {
            await _datiColloquianteRepository.Delete(id);
            return Ok();

        }

        [HttpPut("Id")]

        public async Task<ActionResult<DatiColloquiante>> Put(Guid id, DatiColloquiante datiColloquiante)
        {
            if (id != datiColloquiante.Id)
            {
                return BadRequest();
            }
            await _datiColloquianteRepository.Update(datiColloquiante);
            return Ok(datiColloquiante);

        }

    }
}

