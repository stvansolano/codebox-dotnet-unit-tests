# CodeBox - Unit Testing with .NET (C#)

[Twitter: @stvansolano](https://twitter.com/stvansolano)

## Do you like it? Give a Star! :star:

If you like or are using this project to learn or start your own solution, please give it a star. I appreciate it!

A ready-to-use, multi-purpose dev environment.

## Running some samples

> git clone https://github.com/dotnet/samples.git

## Using .NET CLI project templates

## Create new projects (classlib+xunit)
> dotnet new --list

## Adding references (current directory)
> dotnet add reference ../MyLibrary/MyLibrary.csproj

## Adding sln file
> dotnet new sln

## Adding csproj files
> dotnet sln add MyLibrary/MyLibrary.csproj

## Add Coverlet + xUnit runner

> dotnet add package xunit.runner.visualstudio

then

> dotnet add package coverlet.collector

then

> dotnet add package ReportGenerator
