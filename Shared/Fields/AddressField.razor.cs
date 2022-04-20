using FieldGroups.Shared.Validators;
using FieldGroups.Shared.Fields.Base;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class AddressField :
    FieldBase<string, AddressFieldModel, MudTextField<string>>
{
    [Inject]
    AddressValidator Validator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "Address";
}

public sealed class AddressFieldModel : FieldModelBase<string>
{ }
