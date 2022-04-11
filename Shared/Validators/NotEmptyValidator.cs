using FluentValidation;

namespace FieldGroups.Shared.Validators;

public class NotEmptyValidator : BaseValidator<string>
{
    public NotEmptyValidator()
    {
        RuleFor(x => x)
            .Cascade(CascadeMode.Stop)
            .NotNull()
            .WithMessage("This is required.")
            .NotEmpty()
            .WithMessage("This is required.");
    }
}