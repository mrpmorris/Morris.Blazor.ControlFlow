namespace Morris.Blazor.ControlFlow;

public readonly struct ValueWithIndex<T>
{
	public T Value { get; } = default!;
	public int Index { get; } = 0;

	public ValueWithIndex(T value, int index)
	{
		Index = index;
		Value = value;
	}
}
