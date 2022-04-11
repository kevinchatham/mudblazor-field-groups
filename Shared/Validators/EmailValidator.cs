using FluentValidation;

namespace FieldGroups.Shared.Validators;

public class EmailValidator : BaseValidator<string>
{
    public EmailValidator()
    {
        RuleFor(x => x)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("A valid email address is required.")
            .Length(1, 50)
            .WithMessage("Must not be greater than 50 characters.")
            .EmailAddress()
            .WithMessage("A valid email address is required.");
    }
}