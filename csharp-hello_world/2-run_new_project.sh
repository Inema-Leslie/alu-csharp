#!/usr/bin/env bash
mkdir -p 2-new_project && cd 2-new_project || exit 1
dotnet new console
dotnet restore
dotnet build
dotnet run