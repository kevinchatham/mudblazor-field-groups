using FluentValidation;

namespace FieldGroups.Shared.Validators;

public class PasswordValidator : BaseValidator<string>
{
    public PasswordValidator()
    {
        RuleFor(x => x)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("This is required.")
            .Must(x => x.Length >= 8 && x.Length < 64)
            .WithMessage("Must be between 8 and 64 characters.")
            .Must(x => x.Any(c => !char.IsLetterOrDigit(c)))
            .WithMessage("Must contain at least 1 special character.")
            .Must(x => x.Any(c => char.IsLower(c)))
            .WithMessage("Must contain at least 1 lowercase character.")
            .Must(x => x.Any(c => char.IsUpper(c)))
            .WithMessage("Must contain at least 1 uppercase character.")
            .Must(x => x.Any(c => char.IsDigit(c)))
            .WithMessage("Must contain at least 1 number.");
    }
}