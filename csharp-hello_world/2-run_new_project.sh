#!/usr/bin/env bash
mkdir -p 2-new_project
cd 2-new_project 2>/dev/null
dotnet new console > /dev/null 2>&1
dotnet build > /dev/null 2>&1
dotnet run 2>&1 | grep "Hello"
