namespace FieldGroups.Shared.Fields.Base;

public abstract class FieldModelBase<T> : IFieldModelBase
{
    public T Value { get; set; }
    public bool IsTouched { get; set; }
    public bool IsValid { get; set; }
}