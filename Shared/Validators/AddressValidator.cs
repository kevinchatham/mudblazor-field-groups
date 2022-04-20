namespace FieldGroups.Shared.Validators;

public sealed class AddressValidator : BaseValidator<string>
{
    public sealed override Func<string, Task<IEnumerable<string>>> Validate => (string s) =>
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(s))
            errors.Add(base.Messages.Required);

        var maxLimit = 45;

        if (s?.Length > maxLimit)
            errors.Add(base.Messages.MaxLength(maxLimit));

        return Task.FromResult(errors.AsEnumerable());
    };
}