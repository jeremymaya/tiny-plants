#!/bin/bash

until dotnet ef database update; do
>&2 echo "StoreDbContext updated"
sleep 1
done

>&2 echo "SQL Server is up - executing command"