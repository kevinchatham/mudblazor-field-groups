using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class FirstNameField :
    FieldBase<string, FirstNameFieldModel, NotEmptyValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "First Name";
}

public sealed class FirstNameFieldModel : FieldModelBase<string>
{ }
