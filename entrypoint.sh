#!/bin/sh -l

cd /myapp

dotnet restore
dotnet build
dotnet run "$1 $2"