using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace FieldGroups.Pages;

public partial class Header : ComponentBase
{
    [Parameter]
    public string Text { get; set; }

    [Parameter]
    public Color Color { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }
}