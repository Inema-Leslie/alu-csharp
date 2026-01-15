#!/usr/bin/env bash
mkdir -p 1-new_project
cd 1-new_project
dotnet new console >/dev/null 2>&1
dotnet build