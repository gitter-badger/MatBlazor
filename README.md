# ![MatBlazor](content/logo.svg) ![MatBlazor](content/matblazor.png)

## Material Design components for Blazor and Razor Components
[![NuGet](https://img.shields.io/nuget/v/MatBlazor.svg)](https://www.nuget.org/packages/MatBlazor/)
[![Gitter](https://badges.gitter.im/BlazorComponents/MatBlazor.svg)](https://gitter.im/BlazorComponents/MatBlazor?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge)
[![GitHub Stars](https://img.shields.io/github/stars/blazorcomponents/matblazor.svg)](https://github.com/BlazorComponents/MatBlazor/stargazers)
[![GitHub Issues](https://img.shields.io/github/issues/blazorcomponents/matblazor.svg)](https://github.com/BlazorComponents/MatBlazor/issues)
[![Live Demo](https://img.shields.io/badge/demo-online-green.svg)](https://www.matblazor.com)
[![MIT](https://img.shields.io/github/license/BlazorComponents/MatBlazor.svg)](LICENSE)
[![Donate](https://www.paypalobjects.com/en_US/i/btn/btn_donate_SM.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=9XT68N2VKWTPE&source=url)

MatBlazor comprises a range of components which implement common interaction patterns according to the Material Design specification.


## Demo and Documentation
- [MatBlazor documentation and demo website](https://www.matblazor.com)
- [BlazorFiddle example](https://blazorfiddle.com/s/matblazor-news-client)


![](content/demo-blazor-news-client.png)



## Prerequisites

Don't know what Blazor is? Read [here](https://github.com/aspnet/Blazor)

Complete all Blazor dependencies.

- .NET Core 3.0 Preview 4 SDK (3.0.0-preview4-19216-03)
- Visual Studio 2019 Preview 4 with the ASP.NET and web development workload selected.
- The latest Blazor extension from the Visual Studio Marketplace.
- The Blazor templates on the command-line: dotnet new -i Microsoft.AspNetCore.Blazor.Templates::0.9.0-preview3-19154-02

## Installation 

Latest version in here:  [![NuGet](https://img.shields.io/nuget/v/MatBlazor.svg)](https://www.nuget.org/packages/MatBlazor/)


To Install 

```
Install-Package MatBlazor
```
or 
```
dotnet add package MatBlazor
```

## MatBlazor components for Razor Components
At the beginning of the your Blazor application, usually in `MainLayout.cshtml` please add `<MatBlazorInstall/>` component
```html
<MatBlazorInstall />
```


## Usage

![MatBlazor Buttons Example](content/matblazor-buttons.png)

```html
<MatButton OnClick="@Click">Text @ButtonState</MatButton>
<MatButton Raised="true">Raised</MatButton>
<MatButton Unelevated="true">Unelevated</MatButton>
<MatButton Outlined="true">Outlined</MatButton>
<MatButton Dense="true">Dense</MatButton> 

@functions
{
  string ButtonState = "";
  void Click(UIMouseEventArgs e)
  {
    ButtonState = "Clicked";
  }
} 
```


## Questions

For *how-to* questions and other non-issues, for now you can use issues or you can use [![Gitter](https://badges.gitter.im/BlazorComponents/MatBlazor.svg)](https://gitter.im/BlazorComponents/MatBlazor?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge).

## Contributing

We'd greatly appreciate any contribution you make. :)

## Roadmap

In the near future we plan to maximize the count and features of the components inspired by other frameworks like Angular Material, React Material UI and Vue Material.

## License

This project is licensed under the terms of the [MIT license](LICENSE).

## News

### MatBlazor 0.9.7
- Fixed Drawer problem

### MatBlazor 0.9.6
- All components in one namespace MatBlazor (only one using directive)
- PR: Revert back to C# 7.3 #66 (enkodellc)

### MatBlazor 0.9.5
- Fixed problem with including *.razor files
- PR: #63 MatBlazor Logo / .svg / .ico #65 (enkodellc)

### MatBlazor 0.9.4
- Now we have Logo (many thanks to [enkodellc](https://github.com/enkodellc))
- PR: Prevent *.razor files from being packed #64 (IvanJosipovic)
- Fixed Examples generation

### MatBlazor 0.9.3
- Update to Blazor 3.0.0-preview4-19216-03
- PR: MatTable Table Filter, get data from API #61 (enkodellc, arivera12)
- PR: Fix Table Navigation Error #60 (enkodellc)

### MatBlazor 0.9.2
- PR: MatTable Version 1 #58 (enkodellc, arivera12)

### MatBlazor 0.9.1
- PR: Fixed #50 Autocomplete FullWidth + #52 (sandrohanea)
- PR: MatIconButton Add Functionality, Update Demo #53 (enkodellc)
- PR: Added documentation for autocomplete + Fixed #56 + changed documentation file path to a relative one(instead of absolut) #57 (sandrohanea)

### MatBlazor 0.9.0
- Creating partial documentation for all components (autogeneration)
- Improved many examples
- Improved homepage, components page design, README.md
- Change of versioning policy is similar to Blazor
- Fixed MatTextBox FullWidth Padding / Icon Fix #43 #51 (enkodellc)

### MatBlazor 0.6.17
- Fixed Select is showing native arrow? #48 (sandrohanea)

### MatBlazor 0.6.16
- New component MatAutocomplete (sandrohanea)

### New domain name
- [www.matblazor.com](https://www.matblazor.com)

### MatBlazor 0.6.15
- New component MatSnackbar

### MatBlazor 0.6.14
- New component MatRipple

### MatBlazor 0.6.13
- New styles Layout Grid

### MatBlazor 0.6.12
- New component MatDialog
- MatCheckbox add inline label (enkodellc)

### MatBlazor 0.6.11
- New component MatProgressBar

### MatBlazor 0.6.10
- New styles Elevation
- License of used packages added to js boundle

### MatBlazor 0.6.9
- Changed all events to EventCallback
- Show Icons when MatTextField has FullWidth (enkodellc)

### MatBlazor 0.6.8
- Improved events for MatTextField (sandrohanea + SamProf)

### MatBlazor 0.6.7
- Added Typography styles

### MatBlazor 0.6.6
- Added Href parameter to MatListItem component

### MatBlazor 0.6.5
- MatTextField - fixed label

### MatBlazor 0.6.4
- MatMenu - first working implementation

### MatBlazor 0.6.3
- New MatDrawer
- Fix MatAppBar (fixed-adjust div)

### MatBlazor 0.6.2
- Added Style Parameter for all components
- Added BaseMatComponent Docs
- MatDrawer in progress

### MatBlazor 0.6.1
- Introduce Razor Components support (MatBlazorInstall component)

### MatBlazor 0.6.0
- Upgrade Blazor 0.9 complete
- Upgrade to new Material Components
- MatTextField Outlined fixed
- MatRadioGroup and MatRadioButton enhancements
- MatSelect Outlined fixed
- MatSlider Step problem founded
- Fixed main page of the demo project MatDrawer
- MatMenu (prepared for development in next release)
- MatDrawer (prepared for development in next release)
- BlazorFiddle integration fixed

### MatBlazor 0.5.0
- Upgrade to Blazor 0.9.0 (Part 1)

### MatBlazor 0.4.5 (Minor)
- TrailingIcon in MatButton

### MatBlazor 0.4.4
- Added integration with BlazorFiddle.com
- MatIconButton - Href bacame Link

### MatBlazor 0.4.3
- Upgrade to Blazor 0.7.0
- MatDrawer in progress
