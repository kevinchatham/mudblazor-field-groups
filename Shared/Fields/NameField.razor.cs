using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class NameField :
    FieldBase<string, NameFieldModel, NotEmptyValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "Name";
}

public sealed class NameFieldModel : FieldModelBase<string>
{ }
