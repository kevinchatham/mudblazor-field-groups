using FieldGroups.Shared.Fields;
using FieldGroups.Shared.Fields.Base;
using Microsoft.AspNetCore.Components;

namespace FieldGroups.Pages;

public partial class Index : ComponentBase
{
    FormGroup Form = new();

    private sealed class FormGroup : FieldGroup
    {

    }
}