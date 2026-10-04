using MaktabTaha.Application.Features.baseEntities.charityMainRole;
using MaktabTaha.Application.Features.baseEntities.charityMainRole.Query.List;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class CharityMainRoleController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetCharityMainRolesList()
    {
        return Ok(await Mediator.Send(new GetCharityMainRoleListCommand()));
    }
}
