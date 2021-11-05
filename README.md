#TemplateWebApi ![Build status](https://github.com/gdetra/TemplateWebApi/actions/workflows/nuget.yml/badge.svg) [![NuGet Status](https://img.shields.io/nuget/v/TemplateWebApi.svg?style=flat)](https://www.nuget.org/packages/TemplateWebApi/)

A Web Api Template layered in multiple projects built with .NET 5 and .NET Standard 2.1 .
This project was born with the intent to have a structure of project that allow you to start your web api development in without to write a lot of boilerplate code.

##Installation
```
dotnet new --install TemplateWebApi
```

##How to use
```
 dotnet new template-api-web --name ProjectName -o OutputDirProject
```

##Implementations
* [x] Installer Interface for a cleaner startup class (Take the idea from [Elfocrash](https://github.com/elfocrash)) 
* [ ] [WIP] Use [AutoWrapper](https://github.com/proudmonkey/AutoWrapper) library to have more consistent HTTP response
* [ ] Adding [Scrutor](https://github.com/khellang/Scrutor) library to set all solution services class as scoped for DI

* [ ] Implement model validation with [FluentValidation](https://github.com/FluentValidation/FluentValidation) and integrate it with AutoWrapper
* [ ] Add logging on Filesystem


More will come..


If you want to support this project buy me a coffee

[![](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=2HYWKL2Q287HG)

