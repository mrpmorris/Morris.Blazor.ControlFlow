using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Morris.Blazor.ControlFlow;

public partial class ForEach<TItem>
{
	[Parameter] public IEnumerable<TItem>? Items { get; set; } 
	[Parameter] public RenderFragment<TItem>? ChildContent { get; set; }
}
