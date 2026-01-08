#!/usr/bin/env bash
rm -rf 1-new_project 2>/dev/null
mkdir -p 1-new_project
cd 1-new_project || exit 1

dotnet new console --framework net7.0 > /dev/null 2>&1

dotnet restore > /dev/null 2>&1
dotnet build 2>&1 | grep -A 2 "Build succeeded"

cd ..