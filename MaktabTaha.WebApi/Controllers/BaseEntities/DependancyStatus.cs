using MaktabTaha.Application.Features.baseEntities.dependancyStatus.Query.List;
using MaktabTaha.Application.Features.baseEntities.educationStatus;
using MaktabTaha.Application.Features.baseEntities.educationStatus.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class DependancyStatusController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetDependancyStatussList()
    {
        return Ok(await Mediator.Send(new GetDependancyStatusListCommand()));
    }
}
