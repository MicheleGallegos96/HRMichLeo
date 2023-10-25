using HRMichLeo.Server.Interfaces;
using HRMichLeo.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMichLeo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoftSkillController : ControllerBase
    {
        
        private readonly IRepositoryBase<SoftSkill> _softSkillRepository;

        public SoftSkillController(IRepositoryBase<SoftSkill> softSkillRepository)
        {
            _softSkillRepository = softSkillRepository;
        }

        [HttpGet]
        public async Task<ActionResult<SoftSkill>> GetAll()
        {
            var risultato = await _softSkillRepository.GetAll();
            return Ok(risultato);
        }

        [HttpGet("{Id:guid}")]
        public async Task<ActionResult<SoftSkill>> GetById(Guid id)
        {
            var risultato = await _softSkillRepository.GetById(id);
            return Ok(risultato);
        }

        [HttpPost("Create")]

        public async Task<ActionResult<SoftSkill>> Post(SoftSkill softSkills)
        {
            await _softSkillRepository.Create(softSkills);
            return CreatedAtAction("GetById", new { id = softSkills.Id }, softSkills);

        }

        [HttpDelete("{id:guid}")]

        public async Task<ActionResult<SoftSkill>> Delete(Guid id)
        {
            await _softSkillRepository.Delete(id);
            return Ok();

        }

        [HttpPut("{Id:guid}")]

        public async Task<ActionResult<SoftSkill>> Put(Guid id, SoftSkill softSkills)
        {
            if (id != softSkills.Id)
            {
                return BadRequest();
            }
            await _softSkillRepository.Update(softSkills);
            return Ok(softSkills);

        }

    }
}
    
