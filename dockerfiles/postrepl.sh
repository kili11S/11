#!/bin/bash

set -euxo pipefail

POSTGRES_NODE_TYPES="master slave"

echo "EXECUTING $POSTGRES_NODE_TYPE 113"

psql -U postgres -d storagedb <<'EOSQL'
  create user replicaUser with password 'password';
EOSQL

if [ "$POSTGRES_NODE_TYPE" == "master" ]; then
   echo "this machine is master"
   psql -U postgres -d storagedb <<'EOSQL'
     alter system set wal_level = logical;
     alter user replicaUser replication;
     create publication pub1 for all tables in storagedb;
EOSQL
fi

if [ "$POSTGRES_NODE_TYPE" == "slave" ]; then
   psql -U postgres -d storagedb <<'EOSQL'
     GRANT pg_create_subscription to replicaUser;
     create subscription h_$(uname -n) connection 'dbname=storagedb host=postgres user=replicaUser password=password' publication pub1;
EOSQL
fi
