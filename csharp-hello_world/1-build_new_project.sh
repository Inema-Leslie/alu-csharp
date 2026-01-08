#!/usr/bin/env bash

mkdir -p 1-new_project
cd 1-new_project || exit 1
dotnet new console --name 1-new_project
dotnet restore
dotnet build
cd ..