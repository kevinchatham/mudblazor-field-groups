namespace FieldGroups.Shared.Validators;

public abstract class BaseValidator<T>
{
    public readonly BaseMessages Messages = new();
    public abstract Func<T, Task<IEnumerable<string>>> Validate { get; }

    public class BaseMessages
    {
        public readonly string Required = "This is required.";
        public string MaxLength(int l) => $"Cannot be greater than {l} characters.";
        public string MinLength(int l) => $"Cannot be less than {l} characters.";
        public string Min(int l) => $"Must be above {l}.";
        public string Max(int l) => $"Must be below {l}.";
        public string Length(int l) => $"Must contain {l} characters.";
    }
}