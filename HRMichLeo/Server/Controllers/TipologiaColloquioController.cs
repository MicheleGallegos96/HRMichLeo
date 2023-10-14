using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipologiaColloquioController : ControllerBase
    {

        private readonly IRepositoryBase<TipologiaColloquio> _tipologiaColloquioRepository;

        public TipologiaColloquioController(IRepositoryBase<TipologiaColloquio> tipologiaColloquioRepository)
        {
            _tipologiaColloquioRepository = tipologiaColloquioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<TipologiaColloquio>> GetAll()
        {
            var risultato = await _tipologiaColloquioRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<TipologiaColloquio>> GetById(Guid id)
        {
            var risultato = await _tipologiaColloquioRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<TipologiaColloquio>> Post(TipologiaColloquio tipologiaColloquio)
        {
            await _tipologiaColloquioRepository.Create(tipologiaColloquio);
            return CreatedAtAction("GetById", new { id = tipologiaColloquio.Id }, tipologiaColloquio);

        }

        [HttpDelete("Delete")]

        public async Task<ActionResult<TipologiaColloquio>> Delete(Guid id)
        {
            await _tipologiaColloquioRepository.Delete(id);
            return Ok();

        }

        [HttpPut("Id")]

        public async Task<ActionResult<TipologiaColloquio>> Put(Guid id, TipologiaColloquio tipologiaColloquio)
        {
            if (id != tipologiaColloquio.Id)
            {
                return BadRequest();
            }
            await _tipologiaColloquioRepository.Update(tipologiaColloquio);
            return Ok(tipologiaColloquio);

        }

    }
}
