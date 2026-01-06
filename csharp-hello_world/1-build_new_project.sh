#!/usr/bin/env bash

# Create and initialize a new C# console project
dotnet new console -o 1-new_project

# Build the project and ensure output is shown
dotnet build 1-new_project --verbosity normal