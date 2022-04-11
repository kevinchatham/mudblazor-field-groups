using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class RoleField :
    FieldBase<string, RoleFieldModel, NotEmptyValidator, MudSelect<string>>
{
    public override string Label { get; set; } = "Role";
}

public sealed class RoleFieldModel : FieldModelBase<string>
{ }