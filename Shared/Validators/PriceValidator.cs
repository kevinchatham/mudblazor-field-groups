namespace FieldGroups.Shared.Validators;

public sealed class PriceValidator : BaseValidator<decimal>
{
    public sealed override Func<decimal, Task<IEnumerable<string>>> Validate => (decimal d) =>
    {
        var errors = new List<string>();

        if (d <= 0)
            errors.Add(base.Messages.Min(0));

        return Task.FromResult(errors.AsEnumerable());
    };
}