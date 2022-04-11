namespace FieldGroups.Shared.Validators;

public class AutocompleteValidator<T> : BaseValidator<T>
{
    public AutocompleteValidator()
    {
        RuleFor(x => x);
    }
}