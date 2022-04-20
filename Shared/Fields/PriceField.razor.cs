using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class PriceField :
    FieldBase<decimal, PriceFieldModel, MudNumericField<decimal>>
{
    [Inject]
    PriceValidator Validator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "Price";
}

public sealed class PriceFieldModel : FieldModelBase<decimal>
{ }