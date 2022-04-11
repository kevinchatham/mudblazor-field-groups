using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class DiscountField :
    FieldBase<decimal, DiscountFieldModel, DiscountValidator, MudNumericField<decimal>>
{
    public override string Label { get; set; } = "Discount";

    public decimal Max { get; set; } = 100m;

    Color Color => Model.IsFlatDiscount ? Color.Primary : Color.Default;

    public string AdornmentIcon =>
        Model.IsFlatDiscount ?
            Icons.Material.Filled.MoneyOff :
            Icons.Material.Filled.Percent;

    public async void OnCheckedChanged(bool input)
    {
        Model.IsFlatDiscount = input;

        if (Model.IsFlatDiscount)
            Max = decimal.MaxValue;
        else Max = 100m;

        await Changed(Model.Value);
    }
}

public sealed class DiscountFieldModel : FieldModelBase<decimal>
{
    public bool IsFlatDiscount { get; set; }
}
