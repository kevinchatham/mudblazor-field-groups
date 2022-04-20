using FieldGroups.Shared.Fields.Base;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class RoleField :
    FieldBase<string, RoleFieldModel, MudSelect<string>>
{
    [Parameter]
    public override string Label { get; set; } = "Role";
}

public sealed class RoleFieldModel : FieldModelBase<string>
{ }