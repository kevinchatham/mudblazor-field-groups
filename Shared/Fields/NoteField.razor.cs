using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class NoteField :
    FieldBase<string, NoteFieldModel, BypassValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "Notes";
}

public sealed class NoteFieldModel : FieldModelBase<string>
{ }
