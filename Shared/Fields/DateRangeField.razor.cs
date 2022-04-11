using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class DateRangeField :
    FieldBase<DateRange, DateRangeFieldModel, BaseValidator<DateRange>, MudFormComponent<DateRange, string>>
{
    [Parameter]
    public Func<DateTime, bool> IsDateDisabled { get; set; } = new Func<DateTime, bool>(dt => false);

    [Parameter]
    public DateTime? MinDate { get; set; } = DateTime.MinValue;

    [Parameter]
    public DateTime? MaxDate { get; set; }

    public override string Label { get; set; } = "Date Range";

    MudDateRangePicker Picker;

    protected override async Task Changed(DateRange input)
    {
        if (Validate)
            await Picker.Validate();

        Model.Value = input;
        Model.IsValid = Validate ? !Picker.HasErrors : true;
        Model.IsTouched = Picker.Touched;

        await ModelChanged.InvokeAsync(Model);
    }
}

public sealed class DateRangeFieldModel : FieldModelBase<DateRange>
{ }
