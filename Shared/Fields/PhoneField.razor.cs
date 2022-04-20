using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class PhoneField :
    FieldBase<string, PhoneFieldModel, MudTextField<string>>
{
    [Inject]
    PhoneValidator Validator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "Phone Number";
}

public sealed class PhoneFieldModel : FieldModelBase<string>
{ }
