#!/usr/bin/env bash

# Create and initialize a new C# console project
dotnet new console -o 1-new_project

# Build the project and redirect stderr to stdout
dotnet build 1-new_project 2>&1