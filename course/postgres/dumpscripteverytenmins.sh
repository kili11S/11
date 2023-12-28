#!/bin/sh

while true; do
if [ "$(docker ps -aq -f status=running -f name=postgres)" ]; then
docker exec -it postgres pg_dump -U postgres -d storagedb > ./backupfileloop.sql
echo "Loop"
sleep 600
fi
done
