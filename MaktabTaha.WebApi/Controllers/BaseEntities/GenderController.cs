using MaktabTaha.Application.Features.baseEntities.educationStatus;
using MaktabTaha.Application.Features.baseEntities.educationStatus.Query.List;
using MaktabTaha.Application.Features.baseEntities.gender.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class GenderController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetGendersList()
    {
        return Ok(await Mediator.Send(new GetGenderListCommand()));
    }
}
