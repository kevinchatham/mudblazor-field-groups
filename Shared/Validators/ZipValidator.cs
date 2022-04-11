using FluentValidation;

namespace FieldGroups.Shared.Validators;

public class ZipValidator : BaseValidator<string>
{
    public ZipValidator()
    {
        RuleFor(x => x)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("This is required.")
            .Length(5, 5)
            .WithMessage("Must be 5 digits.");
    }
}