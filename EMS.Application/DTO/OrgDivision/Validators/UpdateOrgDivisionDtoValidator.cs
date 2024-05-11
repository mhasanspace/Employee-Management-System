using FluentValidation;

namespace EMS.Application.DTO.OrgDivision.Validators
{
    public class UpdateOrgDivisionDtoValidator : AbstractValidator<UpdateOrgDivisionDto>
    {
        public UpdateOrgDivisionDtoValidator() 
        {
            Include(new IOrgDivisionDtoValidator());

            RuleFor(v => v.Id).NotNull().WithMessage("Id not found.");
        }
    }
}
