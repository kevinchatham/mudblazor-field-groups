using FieldGroups.Shared.Fields.Base;
using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class PasswordField :
    FieldBase<string, PasswordFieldModel, MudTextField<string>>
{
    [Parameter]
    public bool Confirm { get; set; }

    [Parameter]
    public bool ConfirmDisabled { get; set; }

    [Parameter]
    public override string Label { get; set; } = "Password";
    InputType InputType = InputType.Password;
    string PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
    bool PasswordVisible { get; set; }

    [Parameter]
    public string ConfirmLabel { get; set; } = "Confirm Password";
    InputType ConfirmInputType = InputType.Password;
    string ConfirmPasswordInputIcon = Icons.Material.Filled.VisibilityOff;
    bool ConfirmPasswordVisible { get; set; }
    public MudTextField<string> ConfirmField { get; set; }

    [Inject]
    PasswordValidator PasswordValidator { get; set; }
    readonly MatchesValidator MatchesValidator = new();

    void TogglePasswordVisibility()
    {
        if (PasswordVisible)
        {
            PasswordVisible = false;
            PasswordInputIcon = Icons.Material.Filled.VisibilityOff;
            InputType = InputType.Password;
        }
        else
        {
            PasswordVisible = true;
            PasswordInputIcon = Icons.Material.Filled.Visibility;
            InputType = InputType.Text;
        }
    }

    void ToggleConfirmPasswordVisibility()
    {
        if (ConfirmPasswordVisible)
        {
            ConfirmPasswordVisible = false;
            ConfirmPasswordInputIcon = Icons.Material.Filled.VisibilityOff;
            ConfirmInputType = InputType.Password;
        }
        else
        {
            ConfirmPasswordVisible = true;
            ConfirmPasswordInputIcon = Icons.Material.Filled.Visibility;
            ConfirmInputType = InputType.Text;
        }
    }

    async Task ConfirmChanged(string input)
    {
        // ? For whatever reason things like 'ConfirmField.ResetValidation()'
        // ? just do not work at all. Setting new func is the only work around ?

        var validationResult = await MatchesValidator.Validate((Model.Value, input));
        var count = validationResult.Count();

        Model.ConfirmValue = input;
        Model.IsValid = Validate ? count == 0 : true;
        Model.IsTouched = true;

        if (!Model.IsValid)
        {
            var message = validationResult.First();
            ConfirmField.Validation = new Func<string, string>(x => message);
            await ConfirmField.Validate();
            StateHasChanged();
        }

        await ModelChanged.InvokeAsync(Model);
    }
}

public sealed class PasswordFieldModel : FieldModelBase<string>
{
    public string ConfirmValue { get; set; }
}