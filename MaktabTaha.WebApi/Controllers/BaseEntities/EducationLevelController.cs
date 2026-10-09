using MaktabTaha.Application.Features.baseEntities.educationLevel.Query.List;
using MaktabTaha.Application.Features.baseEntities.educationStatus;
using MaktabTaha.Application.Features.baseEntities.educationStatus.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class EducationLevelController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetEducationLevelsList()
    {
        return Ok(await Mediator.Send(new GetEducationLevelListCommand()));
    }
}
