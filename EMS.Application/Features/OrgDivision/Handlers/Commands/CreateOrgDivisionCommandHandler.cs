using AutoMapper;
using EMS.Application.Contracts.Persistence;
using EMS.Application.DTO.OrgDivision.Validators;
using EMS.Application.Features.OrgDivision.Requests.Commands;
using EMS.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Application.Features.OrgDivision.Handlers.Commands
{
    public class CreateOrgDivisionCommandHandler : IRequestHandler<CreateOrgDivisionCommand, BaseCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateOrgDivisionCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public BaseCommandResponse Handle(CreateOrgDivisionCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateOrgDivisionDtoValidator();
            var validationResult = validator.Validate(request.OrgDivisionDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var orgDivision = _mapper.Map<OrgDivision>(request.OrgDivisionDto);

                orgDivision = _unitOfWork.OrgDivisionRepository.Add(orgDivision);
                _unitOfWork.Save();

                response.Success = true;
                response.Message = "Creation Successful";
                response.Id = orgDivision.Id;
            }

            return response;
        }

    }
}
