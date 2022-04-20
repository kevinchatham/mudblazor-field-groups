using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class NoteField :
    FieldBase<string, NoteFieldModel, MudTextField<string>>
{
    [Inject]
    NoteValidator Validator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "Notes";
}

public sealed class NoteFieldModel : FieldModelBase<string>
{ }
