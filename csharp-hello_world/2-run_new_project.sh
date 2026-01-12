#!/usr/bin/env bash
rm -rf 2-new_project 2>/dev/null
mkdir -p 2-new_project
cd 2-new_project
dotnet new console --force > /dev/null 2>&1 
sed -i 's/Hello, World!/ Hello World!/g' Program.cs
dotnet build > /dev/null 2>&1
dotnet run --no-build 2>&1 | tr -d '\r'

