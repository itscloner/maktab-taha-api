using MaktabTaha.Application.Features.baseEntities.goodWorkType;
using MaktabTaha.Application.Features.baseEntities.goodWorkType.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class GoodWorkTypeController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetGoodWorkTypesList()
    {
        return Ok(await Mediator.Send(new GetGoodWorkTypeListCommand()));
    }
}
