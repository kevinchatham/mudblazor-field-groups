using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class FirstNameField :
    FieldBase<string, FirstNameFieldModel, MudTextField<string>>
{
    [Inject]
    NameValidator Validator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "First Name";
}

public sealed class FirstNameFieldModel : FieldModelBase<string>
{ }
