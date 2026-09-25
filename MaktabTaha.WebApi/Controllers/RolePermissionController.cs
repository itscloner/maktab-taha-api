using MaktabTaha.Application.Features.role_permission.Command.Create;
using MaktabTaha.Application.Features.role_permission.Command.Delete;
using MaktabTaha.Application.Features.role_permission.Command.Update;
using MaktabTaha.Application.Features.role_permission.Query.List;
using MaktabTaha.Application.Features.role_permission.Query.Single;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolePermissionController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateUserPermission(CreateRolePermissionCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> UserPermissionList()
        {
            var result = await Mediator.Send(new GetRolePermissionListCommand());
            return Ok(result);
        }
        [HttpGet("{roleId}/{permissionId}")]
        public async Task<IActionResult> GetUserPermissionById(int roleId, int permissionId)
        {
            var result = await Mediator.Send(new GetRolePermissionByIdCommand() { RoleId = roleId, PermissionId=permissionId });
            return Ok(result);

        }

        [HttpPut("{roleId}/{permissionId}")]
        public async Task<IActionResult> UpdateUserPermission(int roleId, int permissionId, UpdateRolePermissionCommand command)
        {
            if (roleId != command.RoleId && permissionId != command.PermissionId)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{roleId}/{permissionId}")]
        public async Task<IActionResult> Delete(int roleId, int permissionId)
        {
            return Ok(await Mediator
                .Send(new DeleteRolePermissionCommand { RoleId = roleId, PermissionId = permissionId }));
        }
    }
}
