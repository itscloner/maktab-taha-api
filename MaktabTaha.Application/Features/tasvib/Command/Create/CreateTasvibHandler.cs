using AutoMapper;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MaktabTaha.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.tasvib.Command.Create
{
    public class CreateTasvibHandler : IRequestHandler<CreateTasvibCommand, OperationResult<Tasvib>>
    {
        private readonly ITasvibRepository _tasvibRepository;
        private readonly ICaseRepository _caseRepository;
        private readonly IMapper _mapper;

        public CreateTasvibHandler(ITasvibRepository tasvibRepository, ICaseRepository caseRepository, IMapper mapper)
        {
            _tasvibRepository = tasvibRepository;
            _caseRepository = caseRepository;
            _mapper = mapper;
        }

        public async Task<OperationResult<Tasvib>> Handle(CreateTasvibCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<Tasvib>();
            var caseBnf = await _caseRepository.FirstOrDefault(x => x.CaseNumber == request.CaseNumber);
            if (caseBnf == null) return operation.Failure("پرونده‌ای وجود ندارد");

            if (caseBnf.CaseStageId != 3) return operation.Failure("پرونده در مرحله تحقیق نمیباشد");

            var mappedData = _mapper.Map<Tasvib>(request);
            await _tasvibRepository.Create(mappedData);
            return operation.Succedded(mappedData);
             
        }
    }
}
