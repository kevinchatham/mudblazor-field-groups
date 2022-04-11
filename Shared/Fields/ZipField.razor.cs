using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class ZipField :
    FieldBase<string, ZipFieldModel, ZipValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "Zip";
}

public sealed class ZipFieldModel : FieldModelBase<string>
{ }
