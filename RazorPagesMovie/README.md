# aspcore movies example

A basic ASP Core Blazer Web App Examples built with VSCode

The code repo here following the .NET 8 version of the Microsoft Tutorial:

https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio-code

## Getting Started

### To dev build/run

Get tools and packages needed

```
dotnet restore
# ensure they are present
dotnet tool list -g
```

```
pnpm install

[tbd]: some webpack script to copy dist to wwwroot/lib/
of packages
```

### To run:

Create database w. fixtures

```
dotnet ef database update
```

```
f5 # choose b/w builds
```
