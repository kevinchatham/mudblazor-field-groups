using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class StateField :
    FieldBase<string, StateFieldModel, NotEmptyValidator, MudSelect<string>>
{
    public override string Label { get; set; } = "State";
}

public sealed class StateFieldModel : FieldModelBase<string>
{ }