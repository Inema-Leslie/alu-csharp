#!/usr/bin/env bash

# Remove any existing directory
rm -rf 1-new_project

# Create a new console project
dotnet new console -o 1-new_project --force

# Change to the directory and build (this gives cleaner output)
cd 1-new_project && dotnet build