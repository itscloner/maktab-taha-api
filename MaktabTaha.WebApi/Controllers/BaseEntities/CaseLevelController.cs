using MaktabTaha.Application.Features.baseEntities.caseStage.Query.List;
using MaktabTaha.Application.Features.baseEntities.educationStatus;
using MaktabTaha.Application.Features.baseEntities.educationStatus.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class CaseLevelController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetCaseLevelsList()
    {
        return Ok(await Mediator.Send(new GetCaseStageListCommand()));
    }
}
