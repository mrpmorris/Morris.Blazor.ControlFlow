# Morris.Blazor.ControlFlow

![](https://raw.githubusercontent.com/mrpmorris/Morris.Blazor.ControlFlow/master/Images/control-flow-logo.png)


## Releases
### New in 1.0.0
- `ForEach`
```
<ForEach Context=Person In=@People>
  <li>@Person.Name</li>
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