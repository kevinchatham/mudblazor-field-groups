using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class DescriptionField :
    FieldBase<string, DescriptionFieldModel, NotEmptyValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "Description";
}

public sealed class DescriptionFieldModel : FieldModelBase<string>
{ }
