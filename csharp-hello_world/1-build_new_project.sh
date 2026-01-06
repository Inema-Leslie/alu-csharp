#!/usr/bin/env bash

# Create project
dotnet new console -o 1-new_project > /dev/null 2>&1

# Build and capture/output the result
cd 1-new_project
dotnet build