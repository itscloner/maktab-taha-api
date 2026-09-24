using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.role.Command.delete
{
    public class DeleteRoleHandler : IRequestHandler<DeleteRoleCommand, OperationResult<bool>>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;

        public DeleteRoleHandler(IRoleRepository roleRepository, IUserRepository userRepository)
        {
            _roleRepository = roleRepository;
            _userRepository = userRepository;
        }


        public async Task<OperationResult<bool>> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();
            var role = await _roleRepository.FirstOrDefault(x => x.Id == request.Id);
            if (role == null) return operation.Failure("نقش یافت نشد");

            var hasUser = await _userRepository.Exists(x => x.RoleId == request.Id);
            if(hasUser) return operation.Failure("این نقش به یک یا چند کاربر اختصاص داده شده و قابل حذف نیست.");

            await _roleRepository.Delete(role);

            return operation.Succedded(true);

        }
    }
}
