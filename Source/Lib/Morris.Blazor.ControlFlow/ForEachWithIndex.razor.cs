using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace Morris.Blazor.ControlFlow;

public partial class ForEachWithIndex<TItem>
{
#if NET6_0_OR_GREATER
	[EditorRequired]
#endif
	[Parameter] public IEnumerable<TItem>? In { get; set; }
#if NET6_0_OR_GREATER
	[EditorRequired]
#endif
	[Parameter] public RenderFragment<ValueWithIndex<TItem>>? ChildContent { get; set; }
}
