namespace FieldGroups.Shared.Validators;

public class BypassValidator : BaseValidator<string>
{
    public BypassValidator()
    {
        RuleFor(x => x);
    }
}