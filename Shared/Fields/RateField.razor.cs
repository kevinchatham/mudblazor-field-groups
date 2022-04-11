using FieldGroups.Data.Models;
using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class RateField :
    FieldBase<List<Rate>, RateFieldModel, BaseValidator<List<Rate>>, MudBaseInput<List<Rate>>>
{
    public override string Label { get; set; } = "Interval";

    static readonly List<Interval> AllIntervals = new()
    {
        Interval.Daily,
        Interval.Weekly,
        Interval.Monthly,
        Interval.Yearly
    };

    List<Interval> AvailableIntervals = new(AllIntervals);

    async Task PriceChanged(decimal input, int index)
    {
        Model.Value[index].Price = input;
        Model.IsValid = true;
        Model.IsTouched = true;
        await ModelChanged.InvokeAsync(Model);
    }

    async Task IntervalChanged(Interval input, int index)
    {
        Model.Value[index].Interval = input;
        Model.IsValid = true;
        Model.IsTouched = true;
        await ModelChanged.InvokeAsync(Model);
        UpdateAvailableIntervals();
    }

    async Task AddRate()
    {
        UpdateAvailableIntervals();
        Model.Value.Add(new() { Interval = AvailableIntervals.First() });
        await ModelChanged.InvokeAsync(Model);
        UpdateAvailableIntervals();
    }

    async Task RemoveRate(int index)
    {
        Model.Value.RemoveAt(index);
        await ModelChanged.InvokeAsync(Model);
        UpdateAvailableIntervals();
    }

    void UpdateAvailableIntervals()
    {
        AvailableIntervals = new(AllIntervals);
        foreach (var item in Model.Value.Select(x => x.Interval))
            AvailableIntervals.Remove(item);
    }
}

public sealed class RateFieldModel : FieldModelBase<List<Rate>>
{ }