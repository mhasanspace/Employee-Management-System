using FluentValidation;

namespace EMS.Application.DTO.OrgDivision.Validators
{
    public class IOrgDivisionDtoValidator : AbstractValidator<IOrgDivisionDto>
    {
        public IOrgDivisionDtoValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty().WithMessage("OrgDivision name is required.")
                .NotNull()
                .MaximumLength(75).WithMessage("OrgDivision name must must not exceed 75 characters.");

            RuleFor(r => r.Status).NotNull();
        }
    }
}
