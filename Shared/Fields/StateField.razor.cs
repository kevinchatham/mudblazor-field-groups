using FieldGroups.Shared.Fields.Base;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class StateField :
    FieldBase<string, StateFieldModel, MudSelect<string>>
{
    [Parameter]
    public override string Label { get; set; } = "State";
}

public sealed class StateFieldModel : FieldModelBase<string>
{ }