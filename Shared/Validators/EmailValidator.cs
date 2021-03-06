namespace FieldGroups.Shared.Validators;

public sealed class EmailValidator : BaseValidator<string>
{
    public sealed override Func<string, Task<IEnumerable<string>>> Validate => (string s) =>
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(s))
        {
            errors.Add(base.Messages.Required);
            return Task.FromResult(errors.AsEnumerable());
        }

        var maxLimit = 254; // RFC5321

        if (s?.Length > maxLimit)
            errors.Add(base.Messages.MaxLength(maxLimit));

        if (!s.Contains("@") && !s.Contains("."))
            errors.Add("Not a valid email address");

        return Task.FromResult(errors.AsEnumerable());
    };
}