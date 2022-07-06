# Morris.Blazor.ControlFlow

![](https://raw.githubusercontent.com/mrpmorris/Morris.Blazor.ControlFlow/master/Images/control-flow-logo.png)


## Introduction
[![NuGet version (Morris.Blazor.ControlFlow)](https://img.shields.io/nuget/v/Morris.Blazor.ControlFlow.svg?style=flat-square)](https://www.nuget.org/packages/Morris.Blazor.ControlFlow/)

***ControlFlow*** is a Blazor library created to help reduce the amount of C#
code found in markup files.

Instead of this
```
@if (People?.Length > 0)
{
  <ol>
    @foreach (var person in People)
    {
      <li>@person.FullName</li>
    }
  </ol>
}
```

You can write this

```
<If Condition="People?.Length > 0">
  <ol>
    <ForEach Context=person In=People>
      <li>@person.FullName</li>
    </ForEach>
  </ol>
</If>
```

Instead of this
```
@if (People?.Length > 0)
{
  <ol>
    @foreach (var person in People)
    {
      <li>@person.FullName</li>
    }
  </ol>
}
else
{
  <p>No people found</p>
}
```

You can write this

```
<If Condition="People?.Length > 0">
  <Then>
    <ol>
      <ForEach Context=person In=People>
        <li>@person.FullName</li>
      </ForEach>
    </ol>
  </Then>
  <Else>
    <p>No people found</p>
  </Else>
</If>
```

## More information
- View the [Example projects](https://github.com/mrpmorris/Morris.Blazor.ControlFlow/tree/master/Source/Tutorials)
- Read the [Release notes](https://github.com/mrpmorris/Morris.Blazor.ControlFlow/blob/master/Docs/Releases.md)
