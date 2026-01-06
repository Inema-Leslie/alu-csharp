#!/usr/bin/env bash

# Ensure we're in the right location
mkdir -p 0-new_project

# Use the full path approach
dotnet new console --output ./0-new_project --name 0-new_project --force