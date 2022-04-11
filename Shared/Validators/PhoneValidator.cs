using FluentValidation;

namespace FieldGroups.Shared.Validators;

public class PhoneValidator : BaseValidator<string>
{
    public PhoneValidator()
    {
        RuleFor(x => x)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("This is required.")
            .Length(10, 10)
            .WithMessage("Must be 10 digits.");
    }
}