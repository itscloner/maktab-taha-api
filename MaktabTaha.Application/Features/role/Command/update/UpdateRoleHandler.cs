using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.role.Command.update
{
    public class UpdateRoleHandler : IRequestHandler<UpdateRoleCommand, OperationResult<bool>>
    {
        private readonly IRoleRepository _repository;
        private readonly IMapper _mapper;

        public UpdateRoleHandler(IRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<bool>> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();
            var role = await _repository.FirstOrDefault(x => x.Id == request.Id);
            if (role == null) return operation.Failure("نقش یافت نشد");
            var duplicate = await _repository.Exists(x => x.Title == request.Title &&x.Id != request.Id);
            if (duplicate) return operation.Failure("نقش دیگری با این عنوان وجود دارد");

            role.Title = request.Title;
            role.IsSystemAdmin = request.IsSystemAdmin;

            await _repository.Update(role);

            return operation.Succedded(true);

        }
    }
}
