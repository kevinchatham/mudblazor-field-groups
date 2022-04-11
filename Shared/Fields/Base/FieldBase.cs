using FieldGroups.Shared.Validators;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields.Base;

public abstract class FieldBase<T, TModel, TValidator, TInput> : ComponentBase
    where TModel : FieldModelBase<T>
    where TValidator : BaseValidator<T>
    where TInput : MudFormComponent<T, string>
{
    [Parameter]
    public TModel Model { get; set; }

    [Parameter]
    public EventCallback<TModel> ModelChanged { get; set; }

    [Parameter]
    public Variant Variant { get; set; } = Variant.Filled;

    [Parameter]
    public string Class { get; set; }

    [Parameter]
    public string Style { get; set; }

    [Parameter]
    public bool Disabled { get; set; }

    [Parameter]
    public bool Validate { get; set; } = true;

    [Parameter]
    public bool Immediate { get; set; }

    [Parameter]
    public abstract string Label { get; set; }

    [Inject]
    protected TValidator Validator { get; set; }

    protected BaseValidator<T> _Validator { get; set; } = new();

    protected TInput Field { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (Validate)
            _Validator = Validator;

        await base.OnInitializedAsync();
    }

    protected virtual async Task Changed(T input)
    {
        if (Validate)
            await Field.Validate();

        Model.Value = input;
        Model.IsValid = Validate ? !Field.HasErrors : true;
        Model.IsTouched = Field.Touched;

        await ModelChanged.InvokeAsync(Model);
    }
}