namespace FieldGroups.Shared.Validators;

public sealed class PhoneValidator : BaseValidator<string>
{
    public sealed override Func<string, Task<IEnumerable<string>>> Validate => (string s) =>
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(s))
            errors.Add(base.Messages.Required);

        var limit = 10;

        if (s?.Length > limit)
            errors.Add(base.Messages.Length(limit));

        return Task.FromResult(errors.AsEnumerable());
    };
}