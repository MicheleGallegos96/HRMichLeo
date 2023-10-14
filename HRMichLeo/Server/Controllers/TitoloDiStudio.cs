using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitoloDiStudioController : ControllerBase
    {
        private readonly IRepositoryBase<TitoloDiStudio> _titoloDiStudioRepository;

        public TitoloDiStudioController(IRepositoryBase<TitoloDiStudio> titoloDiStudioRepository)
        {
            _titoloDiStudioRepository = titoloDiStudioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<TitoloDiStudio>> GetAll()
        {
            var risultato = await _titoloDiStudioRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<TitoloDiStudio>> GetById(Guid id)
        {
            var risultato = await _titoloDiStudioRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<TitoloDiStudio>> Post(TitoloDiStudio titoloDiStudio)
        {
            await _titoloDiStudioRepository.Create(titoloDiStudio);
            return CreatedAtAction("GetById", new { id = titoloDiStudio.Id }, titoloDiStudio);

        }

        [HttpDelete("Delete")]

        public async Task<ActionResult<TitoloDiStudio>> Delete(Guid id)
        {
            await _titoloDiStudioRepository.Delete(id);
            return Ok();

        }

        [HttpPut("Id")]

        public async Task<ActionResult<TitoloDiStudio>> Put(Guid id, TitoloDiStudio titoloDiStudio)
        {
            if (id != titoloDiStudio.Id)
            {
                return BadRequest();
            }
            await _titoloDiStudioRepository.Update(titoloDiStudio);
            return Ok(titoloDiStudio);

        }

    }
}
