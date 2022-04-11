namespace FieldGroups.Shared.Fields.Base;

// ! Needed for casting reflection to reference properties in FormGroup
public interface IFieldModelBase
{
    bool IsTouched { get; set; }
    bool IsValid { get; set; }
}