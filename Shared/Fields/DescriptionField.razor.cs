using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class DescriptionField :
    FieldBase<string, DescriptionFieldModel, MudTextField<string>>
{
    [Inject]
    DescriptionValidator Validator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "Description";
}

public sealed class DescriptionFieldModel : FieldModelBase<string>
{ }
