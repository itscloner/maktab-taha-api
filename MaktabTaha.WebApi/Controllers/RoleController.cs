using MaktabTaha.Application.Features.role.Command.create;
using MaktabTaha.Application.Features.role.Command.delete;
using MaktabTaha.Application.Features.role.Command.update;
using MaktabTaha.Application.Features.role.Query.list;
using MaktabTaha.Application.Features.role.Query.single;
using MaktabTaha.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleCommand command)
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

        //[HttpGet("ExportExcel")]
        //public async Task<IActionResult> RoleList()
        //{
        //    var data = await Mediator.Send(new GetRoleListCommand());

        //    var columns = new List<string>
        //    {
        //        "Title",
        //        "IsSystemAdmin",
        //    };

        //    var headers = new Dictionary<string, string>
        //    {
        //        { "Title", "عنوان" },
        //        { "IsSystemAdmin", "ادمین بودن" }
        //    };

        //    var excelBytes = ExcelHelper.GenrateExcel(
        //        data.Data,
        //        "Roles",
        //        columns,
        //        headers);

        //    return File(
        //        excelBytes,
        //        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
        //        "Roles.xlsx");
        //}

        [HttpGet]
        public async Task<IActionResult> GetRoleList()
        {
            return Ok(await Mediator.Send(new GetRoleListCommand()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var result = await Mediator.Send(new GetRoleByIdCommand() { Id = id });
            return Ok(result);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(int id, UpdateRoleCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator
                .Send(new DeleteRoleCommand { Id = id }));
        }
    }
}
