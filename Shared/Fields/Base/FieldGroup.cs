namespace FieldGroups.Shared.Fields.Base;

public class FieldGroup
{
    public bool IsValid => GetType()
        .GetProperties()
        .Where(p => p.PropertyType != typeof(bool))
        .Select(i => (IFieldModelBase)i.GetValue(this))
        .All(x => x.IsValid);

    public bool IsTouched => GetType()
        .GetProperties()
        .Where(p => p.PropertyType != typeof(bool))
        .Select(i => (IFieldModelBase)i.GetValue(this))
        .Any(x => x.IsTouched);

    public bool SubmitDisabled => !IsValid || !IsTouched;

    public void MarkAllValid()
    {
        GetType()
            .GetProperties()
            .Where(p => p.PropertyType != typeof(bool))
            .Select(i => (IFieldModelBase)i.GetValue(this))
            .ToList()
            .ForEach(property =>
            {
                property.IsValid = true;
            });
    }
}