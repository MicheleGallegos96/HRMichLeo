using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HardSkillController : ControllerBase
    {
        private readonly IRepositoryBase<HardSkill> _hardSkillRepository;

        public HardSkillController(IRepositoryBase<HardSkill> hardSkillRepository)
        {
            _hardSkillRepository = hardSkillRepository;
        }

        [HttpGet]
        public async Task<ActionResult<HardSkill>> GetAll()
        {
            var risultato = await _hardSkillRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<HardSkill>> GetById(Guid id)
        {
            var risultato = await _hardSkillRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<HardSkill>> Post(HardSkill hardSkills)
        {
            await _hardSkillRepository.Create(hardSkills);
            return CreatedAtAction("GetById", new { id = hardSkills.Id }, hardSkills);

        }

        [HttpDelete("Delete")]

        public async Task<ActionResult<HardSkill>> Delete(Guid id)
        {
            await _hardSkillRepository.Delete(id);
            return Ok();

        }

        [HttpPut("Id")]

        public async Task<ActionResult<HardSkill>> Put(Guid id, HardSkill hardSkills)
        {
            if (id != hardSkills.Id)
            {
                return BadRequest();
            }
            await _hardSkillRepository.Update(hardSkills);
            return Ok(hardSkills);

        }
    }
}
