# Morris.Blazor.ControlFlow

![](https://raw.githubusercontent.com/mrpmorris/Morris.Blazor.ControlFlow/master/Images/control-flow-logo.png)


## Releases

### New in 2.1
- Support only .NET 8 and 9.

### New in 2.0
- Add support for .NET 7
- Remove support for .NET frameworks no longer supported by Microsoft

### New in 1.1.0
- `ForEachWithIndex`

```
<ForEachWithIndex Context=item in @People>
  <tr>
    <td>@item.Index
    <td>@item.Value.Name
  </tr>
</ForEachWithIndex>
```

### New in 1.0.0
- `ForEach`
```
<ForEach Context=person In=@People>
  <li>@person.Name</li>
```

- Simple `If`
```
<If Condition=@true>
	Content
</If>
```
- `If` with `Else`
```
<If Condition=@true>
	<Then>
		Content
	</Then>
	<Else>
		Other content
	</Else>
</If>
```
