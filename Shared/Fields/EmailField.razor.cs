using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class EmailField :
    FieldBase<string, EmailFieldModel, EmailValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "Email";
}

public sealed class EmailFieldModel : FieldModelBase<string>
{ }
