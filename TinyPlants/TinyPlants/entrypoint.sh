#!/bin/bash

set -e
run_cmd="ASPNETCORE_URLS=http://*:$PORT dotnet TinyPlants.dll"

until dotnet ef database update; do
>&2 echo "StoreDbContext updated"
sleep 1
done

>&2 echo "SQL Server is up - executing command"
exec $run_cmd