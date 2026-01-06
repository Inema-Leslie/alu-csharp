#!/usr/bin/env bash

# Create the 0-new_project directory
mkdir -p 0-new_project

# Change to the directory
cd 0-new_project

# Create the console project (this will create files in the current directory)
dotnet new console

# Exit the directory
cd ..