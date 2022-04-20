using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class LastNameField :
    FieldBase<string, LastNameFieldModel, MudTextField<string>>
{
    [Inject]
    NameValidator Validator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "Last Name";
}

public sealed class LastNameFieldModel : FieldModelBase<string>
{ }
