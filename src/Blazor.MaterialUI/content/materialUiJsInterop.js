// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

Blazor.registerFunction('Blazor.MaterialUI.ExampleJsInterop.AppendStyle', function (message) {
    head = document.head || document.getElementsByTagName('head')[0],
        style = document.createElement('style');

    style.type = 'text/css';
    if (style.styleSheet) {
        style.styleSheet.cssText = message;
    } else {
        style.appendChild(document.createTextNode(message));
    }

    head.appendChild(style);
});
