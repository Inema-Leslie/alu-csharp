#!/usr/bin/env bash
mkdir -p 1-new_project
cd 1-new_project
dotnet new console --name 1-new_project > /dev/null 2>&1
dotnet restore > /dev/null 2>&1
dotnet build 2>&1 | tail -4
cd ..