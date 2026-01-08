#!/usr/bin/env bash
mkdir -p 1-new_project
cd 1-new_project
dotnet new console --framework net7.0
dotnet restore
dotnet build
cd ..