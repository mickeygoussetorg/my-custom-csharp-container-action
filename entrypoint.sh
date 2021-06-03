#!/bin/sh -l

cd /myapp

dotnet restore
dotnet build
dotnet run "$INPUT_PARAMETER"