using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class LastNameField :
    FieldBase<string, LastNameFieldModel, NotEmptyValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "Last Name";
}

public sealed class LastNameFieldModel : FieldModelBase<string>
{ }
