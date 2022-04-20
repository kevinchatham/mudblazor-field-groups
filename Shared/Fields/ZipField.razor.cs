using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class ZipField :
    FieldBase<string, ZipFieldModel, MudTextField<string>>
{
    [Inject]
    ZipValidator Validator { get; set; }

    public override string Label { get; set; } = "Zip";
}

public sealed class ZipFieldModel : FieldModelBase<string>
{ }
