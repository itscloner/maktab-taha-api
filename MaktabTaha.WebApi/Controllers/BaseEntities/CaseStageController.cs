using MaktabTaha.Application.Features.baseEntities.caseStage.Query.List;
using MaktabTaha.Application.Features.baseEntities.educationStatus;
using MaktabTaha.Application.Features.baseEntities.educationStatus.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class CaseStageController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetCaseStagesList()
    {
        return Ok(await Mediator.Send(new GetCaseStageListCommand()));
    }
}
