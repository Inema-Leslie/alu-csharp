#!/usr/bin/env bash
mkdir -p 2-new_project
cd 2-new_project

dotnet new console --force > /dev/null 2>&1 
dotnet build > /dev/null 2>&1
dotnet run --no-build

