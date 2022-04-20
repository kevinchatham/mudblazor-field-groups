namespace FieldGroups.Shared.Validators;

public sealed class MatchesValidator : BaseValidator<(string, string)>
{
    public sealed override Func<(string, string), Task<IEnumerable<string>>> Validate => ((string, string) s) =>
    {
        var errors = new List<string>();

        if (!s.Item1.Equals(s.Item2))
            errors.Add("These do not match.");

        return Task.FromResult(errors.AsEnumerable());
    };
}