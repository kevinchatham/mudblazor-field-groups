using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class CityField :
    FieldBase<string, CityFieldModel, MudTextField<string>>
{
    [Inject]
    CityValidator Validator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "City";
}

public sealed class CityFieldModel : FieldModelBase<string>
{ }
