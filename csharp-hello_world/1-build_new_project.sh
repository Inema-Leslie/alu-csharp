#!/usr/bin/env bash
mkdir -p 1-new_project
cd 1-new_project
dotnet new console --name 1-new_project --framework net7.0
dotnet restore
dotnet build
cd ..