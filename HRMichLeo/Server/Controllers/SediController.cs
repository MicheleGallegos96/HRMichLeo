using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SediController : ControllerBase
    {
        private readonly IRepositoryBase<Sede> _sedeService;

        public SediController(IRepositoryBase<Sede> sediService)
        {
            _sedeService = sediService;
        }

        [HttpGet]
        public async Task<ActionResult<Sede>> GetAll()
        {
            var risultato = await _sedeService.GetAll();

            return Ok(risultato);
        }

        [HttpGet("id")]
        public async Task<ActionResult<Sede>> GetById(Guid id)
        {
            var risultato = await _sedeService.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Add")]
        public async Task<ActionResult<Sede>> Post(Sede Sedi)
        {
            await _sedeService.Create(Sedi);
            return CreatedAtAction("GetById", new { id = Sedi.Id }, Sedi);
        }

        [HttpDelete("Delete")]
        public async Task<ActionResult<Sede>> Delete(Guid Id)
        {
            await _sedeService.Delete(Id);
            return Ok();
        }
    }
}
