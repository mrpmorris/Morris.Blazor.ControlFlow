using Microsoft.AspNetCore.Components;
using System;

namespace Morris.Blazor.ControlFlow;

public partial class If
{
#if NET6_0_OR_GREATER
	[EditorRequired]
#endif
	[Parameter] public bool Condition { get; set; }
	[Parameter] public RenderFragment? ChildContent { get; set; }
	[Parameter] public RenderFragment? Then { get; set; }
	[Parameter] public RenderFragment? Else { get; set; }
}
