using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;

namespace MaktabTaha.Application.Features.role_permission.Command.Update
{
    public class UpdateRolePermissionHandler : IRequestHandler<UpdateRolePermissionCommand, OperationResult<RolePermission>>
    {
        private readonly IRolePermissionRepository _respository;
        private readonly IMapper _mapper;

        public UpdateRolePermissionHandler(IRolePermissionRepository respository, IMapper mapper)
        {
            _respository = respository;
            _mapper = mapper;
        }

        public async Task<OperationResult<RolePermission>> Handle(UpdateRolePermissionCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<RolePermission>();
            var rolePermission = await _respository.SingleOrDefault(x => x.RoleId == request.RoleId && x.PermissionId == request.PermissionId);
            if (rolePermission == null) return operation.Failure("مجوز یافت نشد");
            _mapper.Map(request, rolePermission);

            await _respository.Update(rolePermission);
            return operation.Succedded(rolePermission);



        }
    }
}
