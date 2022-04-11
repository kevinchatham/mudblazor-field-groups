using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class CityField :
    FieldBase<string, CityFieldModel, NotEmptyValidator, MudTextField<string>>
{
    public override string Label { get; set; } = "City";
}

public sealed class CityFieldModel : FieldModelBase<string>
{ }
