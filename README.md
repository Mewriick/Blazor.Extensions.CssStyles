# Blazor.Extensions.CssStyles

> Define Css classes straight in your Blazor components.
> Easy way for conditionally joining class names together.

## IMPORTANT!
**Still development not completely finished** 

# Instal
[![NuGet Pre Release](https://img.shields.io/badge/nuget-v0.1.1-orange.svg)](https://www.nuget.org/packages/Blazor.Extensions.CssStyles/)

# Setup
In app client register required services
```cs
var serviceProvider = new BrowserServiceProvider(services =>
{
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
			.WithStyle(CssPropertyNames.Border,
				NumberCssStyleValue.CreatePixelValue(5),
				TextCssStyleValue.CreateTextValue("dotted"))
			.AddPseudoSelector(PseudoSelector.Hover, props => props
				.WithStyle(CssPropertyNames.Color, "red")
				.WithStyle(CssPropertyNames.Width, "20px"))
			.AddMediaQuery("@media (min-width: 1024px)", props =>
				props.WithStyle(CssPropertyNames.Width, "50px"));
				
	ExportStyles(cssClass);
   }
}
```

**Important is to call method** ``ExportStyles``, which export defined styles into HTML DOM.

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

# Dynamic css class names
```cs
new RuleBasedCssClassNames()
    .AddCssClass("foo")
    .AddCssClassApplyRule("bar", () => true)
    .AddCssClassApplyRule("baz", () => false)
	.BuildCssClassNames(); // "foo bar"
```

```cs
<button class=@(buttonClasses.BuildCssClassNames()) onclick="@IncrementCount">Click me</button>

@functions {
    int currentCount = 0;
    CssClass cssClassGreen;
    CssClass cssClassRed;
    RuleBasedCssClassNames buttonClasses;

    void IncrementCount()
    {
        currentCount++;
    }

    protected override void OnInit()
    {
        base.OnInit();

        cssClassGreen = new CssClass("Button").WithStyle(CssPropertyNames.Color, "green");
        cssClassRed = new CssClass("Button").WithStyle(CssPropertyNames.Color, "red");
        buttonClasses = new RuleBasedCssClassNames()
                        .AddCssClassApplyRule(cssClassGreen, () => currentCount % 2 == 0)
                        .AddCssClassApplyRule(cssClassRed, () => currentCount % 2 > 0);


        ExportStyles(cssClassGreen, cssClassRed);
    }
}
```

# Demo
// TODO
