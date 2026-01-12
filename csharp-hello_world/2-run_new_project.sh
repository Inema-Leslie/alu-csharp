#!/usr/bin/env bash
mkdir -p 2-new_project
cd 2-new_project

dotnet new console --force 
dotnet build
dotnet run

cd ..