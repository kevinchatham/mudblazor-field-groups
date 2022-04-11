using FluentValidation;

namespace FieldGroups.Shared.Validators;

public class BaseValidator<T> : AbstractValidator<T>
{
    public Func<T, Task<string>> ValidateValue => async (model) =>
    {
        if (model is null) return null;

        var result = await ValidateAsync(model);

        if (result.Errors.Count > 0)
            return result.Errors.First().ErrorMessage;

        return null; // needed by MudInputBase otherwise error is literally ''
    };
}