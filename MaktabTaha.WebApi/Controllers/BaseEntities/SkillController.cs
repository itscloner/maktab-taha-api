using MaktabTaha.Application.Features.baseEntities.skill.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class SkillController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetSkillsList()
    {
        return Ok(await Mediator.Send(new GetSkillListCommand()));
    }
}
