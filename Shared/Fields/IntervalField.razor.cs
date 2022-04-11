using FieldGroups.Data.Models;
using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class IntervalField :
    FieldBase<Interval, IntervalFieldModel, BaseValidator<Interval>, MudSelect<Interval>>
{
    public override string Label { get; set; } = "Interval";
}

public sealed class IntervalFieldModel : FieldModelBase<Interval>
{ }