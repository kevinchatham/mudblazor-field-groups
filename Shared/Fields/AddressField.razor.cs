using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class AddressField :
    FieldBase<string, AddressFieldModel, NotEmptyValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "Address";
}

public sealed class AddressFieldModel : FieldModelBase<string>
{ }
