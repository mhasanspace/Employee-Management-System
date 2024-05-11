using FluentValidation;

namespace EMS.Application.DTO.OrgDivision.Validators
{
    public class CreateOrgDivisionDtoValidator : AbstractValidator<CreateOrgDivisionDto>
    {
        public CreateOrgDivisionDtoValidator()
        {
            Include(new IOrgDivisionDtoValidator());
        }
    }
}
