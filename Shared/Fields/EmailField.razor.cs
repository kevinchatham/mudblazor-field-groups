using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class EmailField :
    FieldBase<string, EmailFieldModel, MudTextField<string>>
{
    [Parameter]
    public bool ValidateExisting { get; set; }

    [Inject]
    EmailExistsValidator EmailExistsValidator { get; set; }

    [Inject]
    EmailValidator EmailValidator { get; set; }

    [Parameter]
    public override string Label { get; set; } = "Email";

    Func<string, Task<IEnumerable<string>>> _Validator { get; set; }

    protected override void OnInitialized()
    {
        if (ValidateExisting)
            _Validator = EmailExistsValidator.Validate;
        else _Validator = EmailValidator.Validate;

        base.OnInitialized();
    }
}

public sealed class EmailFieldModel : FieldModelBase<string>
{ }
