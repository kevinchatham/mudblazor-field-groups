using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class NameField :
    FieldBase<string, NameFieldModel, MudTextField<string>>
{
    [Inject]
    NameValidator Validator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "Name";
}

public sealed class NameFieldModel : FieldModelBase<string>
{ }
