#!/bin/sh

set -euxo pipefail

echo "Creating dumpfile"

docker exec -it postgres pg_dump -U postgres -d storagedb > ./backupfile.sql
