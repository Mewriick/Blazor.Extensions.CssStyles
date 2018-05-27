# Blazor.Extensions.CssStyles

> Define Css classes straight in your Blazor components.
> Easy way for conditionally joining class names together.

## IMPORTANT!
**Still development not completely finished** 

# Instal
// TODO

# Setup
In app client register required services
```cs
var serviceProvider = new BrowserServiceProvider(services =>
{
    // Add any custom services here
    services.AddCss();
});
```
In your Blazor component add Tag helper and **Inherit from ComponentWithStyles**
```cs
@addTagHelper *, Blazor.Extensions.CssStyles
@using Blazor.Extensions.CssStyles.Css;
@inherits Blazor.Extensions.CssStyles.Components.ComponentWithStyles
```

# Example

```cs
<button class=@(cssClass.Name) onclick="@IncrementCount">Click me</button>

@functions {
	int currentCount = 0;
	CssClass cssClass;

	void IncrementCount()
	{
		currentCount++;
	}

	protected override void OnInit()
	{
		base.OnInit();

		cssClass = new CssClass("Button")
				.WithStyle(CssPropertyNames.Color, "green")
				.WithStyle(CssPropertyNames.Margin, "20px")
				.WithlStyleInPixelUnit(CssPropertyNames.PaddingLeft, 12)
				.WithStyle(CssPropertyNames.PaddingBottom, 15, CssUnits.Em)
				.WithStyle(CssPropertyNames.Border, NumberCssStyleValue.CreatePixelValue(5), TextCssStyleValue.CreateTextValue("dotted"))
			.AddPseudoSelector(PseudoSelector.Hover, props => props
				.WithStyle(CssPropertyNames.Color, "red")
				.WithStyle(CssPropertyNames.Width, "20px"))
		   .AddMediaQuery("@media (min-width: 1024px)", props =>
				props.WithStyle(CssPropertyNames.Width, "50px"));
	}
}
```

Result
```html
<style type="text/css">
 .Button-1399409485 {
	color: green;
	margin: 20px;
	padding-left: 12px;
	padding-bottom: 15em;
	border: 5px dotted;
}
 .Button-1399409485:hover {
	color: red;
	width: 20px;
}

 @media (min-width: 1024px) {
	 .Button-1399409485 {
		width: 50px;
	 }
}
</style>

<button class="Button-1399409485">Click me</button>
```
# Demo
// TODO
