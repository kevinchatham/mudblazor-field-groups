namespace FieldGroups.Shared.Validators;

public sealed class NoteValidator : BaseValidator<string>
{
    public sealed override Func<string, Task<IEnumerable<string>>> Validate => (string s) =>
    {
        var errors = new List<string>();

        var maxLimit = 250;

        if (s?.Length > maxLimit)
            errors.Add(base.Messages.MaxLength(maxLimit));

        return Task.FromResult(errors.AsEnumerable());
    };
}