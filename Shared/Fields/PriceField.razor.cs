using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class PriceField :
    FieldBase<decimal, PriceFieldModel, PriceValidator, MudNumericField<decimal>>
{
    public override string Label { get; set; } = "Price";
}

public sealed class PriceFieldModel : FieldModelBase<decimal>
{ }