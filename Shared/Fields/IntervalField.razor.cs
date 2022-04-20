using FieldGroups.Data.Models;
using FieldGroups.Shared.Fields.Base;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class IntervalField :
    FieldBase<Interval, IntervalFieldModel, MudSelect<Interval>>
{
    [Parameter]
    public override string Label { get; set; } = "Interval";
}

public sealed class IntervalFieldModel : FieldModelBase<Interval>
{ }