using MaktabTaha.Application.Features.baseEntities.educationStatus;
using MaktabTaha.Application.Features.baseEntities.educationStatus.Query.List;
using MaktabTaha.Application.Features.baseEntities.maritalStatus.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class MaritalStatusController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetMaritalStatussList()
    {
        return Ok(await Mediator.Send(new GetMaritalStatusListCommand()));
    }
}
