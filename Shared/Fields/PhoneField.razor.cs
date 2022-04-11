using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class PhoneField :
    FieldBase<string, PhoneFieldModel, PhoneValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "Phone Number";
}

public sealed class PhoneFieldModel : FieldModelBase<string>
{ }
