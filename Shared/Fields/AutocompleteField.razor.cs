using FieldGroups.Shared.Fields.Base;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Shared.Fields;

public partial class AutocompleteField<T> :
    FieldBase<T, AutocompleteFieldModel<T>, MudAutocomplete<T>>
{
    [Parameter]
    public RenderFragment<T> ItemTemplate { get; set; }

    [Parameter]
    public RenderFragment<T> ItemSelectedTemplate { get; set; }

    [Parameter]
    public Func<T, string> ToStringFunc { get; set; }

    [Parameter]
    public Func<string, Task<IEnumerable<T>>> SearchFunc { get; set; }

    [Parameter]
    public bool CoerceText { get; set; } = true;

    [Parameter]
    public bool CoerceValue { get; set; }

    [Parameter]
    public override string Label { get; set; }
}

public class AutocompleteFieldModel<T> : FieldModelBase<T>
{ }