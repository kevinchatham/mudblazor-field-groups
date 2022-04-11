using FluentValidation;

namespace FieldGroups.Shared.Validators;

public class ConfirmPasswordValidator : BaseValidator<(string, string)>
{
    public ConfirmPasswordValidator()
    {
        var passwordValidator = new PasswordValidator();
        RuleFor(x => x)
            .Must(x =>
            {
                if (string.IsNullOrEmpty(x.Item1))
                    return true;
                return passwordValidator.Validate(x.Item1).IsValid;
            })
            .WithMessage("Password is not valid.")
            .Must(x => x.Item1 == x.Item2)
            .WithMessage("Passwords must match.");
    }
}