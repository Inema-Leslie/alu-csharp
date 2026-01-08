#!/usr/bin/env bash
mkdir -p 1-new_project
cd 1-new_project || exit 1
dotnet new console --name 1-new_project --framework net7.0 > /dev/null
dotnet restore > /dev/null
dotnet build
cd ..