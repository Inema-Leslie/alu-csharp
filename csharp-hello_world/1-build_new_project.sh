#!/usr/bin/env bash

# Clean start
rm -rf 1-new_project

# Create project
dotnet new console -o 1-new_project

# Build with Debug configuration (default) and show output
cd 1-new_project
dotnet build --configuration Debug --verbosity normal