namespace FieldGroups.Shared.Validators;

public sealed class PasswordValidator : BaseValidator<string>
{
    public sealed override Func<string, Task<IEnumerable<string>>> Validate => (string s) =>
    {
        var errors = new List<string>();

        if (string.IsNullOrWhiteSpace(s))
        {
            errors.Add(base.Messages.Required);
            return Task.FromResult(errors.AsEnumerable());
        }

        if (s.Length < 8 || s.Length >= 64)
            errors.Add("Must be between 8 and 64 characters.");

        if (!s.Any(c => char.IsLetterOrDigit(c)))
            errors.Add("Must contain at least 1 special character.");

        if (!s.Any(c => char.IsLower(c)))
            errors.Add("Must contain at least 1 lowercase character.");

        if (!s.Any(c => char.IsUpper(c)))
            errors.Add("Must contain at least 1 uppercase character.");

        if (!s.Any(c => char.IsDigit(c)))
            errors.Add("Must contain at least 1 number.");

        return Task.FromResult(errors.AsEnumerable());
    };
}