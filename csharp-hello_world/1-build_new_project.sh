#!/usr/bin/env bash
mkdir -p 1-new_project
cd 1-new_project
echo '{
  "sdk": {
    "version": "7.0.120",
    "rollForward": "disable"
  }
}' > global.json
dotnet new console --name 1-new_project
dotnet restore
dotnet build
cd ..