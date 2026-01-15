#!/usr/bin/env bash

mkdir -p 1-new_project
cd 1-new_project || exit
dotnet new console 1>/dev/null
dotnet build