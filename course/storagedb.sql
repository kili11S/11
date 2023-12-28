CREATE SCHEMA storagedbscheme AUTHORIZATION postgres;

CREATE TABLE IF NOT EXISTS storagedbscheme.material (
    id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    name text NOT NULL,
    mass integer NOT NULL,
    cubicmetres integer NOT NULL
);

CREATE TABLE IF NOT EXISTS storagedbscheme.storages (
    id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    address text NOT NULL,
    sizemetres integer NOT NULL
);

CREATE TABLE IF NOT EXISTS storagedbscheme.suppliers (
    id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    name text NOT NULL,
    contacts text NOT NULL,
    supplied_mat integer,
    foreign key (supplied_mat) references storagedbscheme.material(id)
);


CREATE TABLE IF NOT EXISTS storagedbscheme.requestors (
    id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    name text NOT NULL,
    contacts text NOT NULL
);

CREATE TABLE IF NOT EXISTS storagedbscheme.stored_material_info (
    id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    storage_related integer,
    foreign key (storage_related) references storagedbscheme.storages(id),
    material_related integer,
    foreign key (material_related) references storagedbscheme.material(id),
    material_quantity integer NOT NULL
);

CREATE TABLE IF NOT EXISTS storagedbscheme.decrease_log (
    id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    rel_req integer,
    foreign key (rel_req) references storagedbscheme.requestors(id),
    rel_strg integer,
    foreign key (rel_strg) references storagedbscheme.storages(id),
    rel_material integer,
    foreign key (rel_material) references storagedbscheme.material(id),
    daterequest date NOT NULL,
    material_quantity integer NOT NULL
);

CREATE TABLE IF NOT EXISTS storagedbscheme.supply_log (
    id integer GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    datesupl date NOT NULL,
    rel_strg integer,
    foreign key (rel_strg) references storagedbscheme.storages(id),
    rel_supl integer,
    foreign key (rel_supl) references storagedbscheme.suppliers(id),
    rel_material integer,
    foreign key (rel_material) references storagedbscheme.material(id),
    material_quantity integer NOT NULL
);

INSERT INTO storagedbscheme.material (name, mass, cubicmetres)
VALUES
('Solid Wood', 15, 3),
('Iron', 25, 2),
('Stainless Steel', 11, 1);

INSERT INTO storagedbscheme.storages (address, sizemetres)
VALUES 
('Long Avenue 16', 250),
('Short Alley 12', 150);

INSERT INTO storagedbscheme.suppliers (name, contacts, supplied_mat)
VALUES
('Ice Inc.', '79213341312', 2),
('Aley Co.', '89223314561', 1);

INSERT INTO storagedbscheme.requestors (name, contacts)
VALUES
('Factory One', '79913131213'),
('Industry Two', '79928123612');

INSERT INTO storagedbscheme.stored_material_info (storage_related, material_related, material_quantity)
VALUES
(1, 1, 13),
(1, 2, 3),
(1, 3, 6),
(2, 1, 3),
(2, 3, 6);

INSERT INTO storagedbscheme.decrease_log (rel_req, rel_strg, rel_material, daterequest, material_quantity)
VALUES
(1, 1, 2, '2004-06-28', 2),
(2, 1, 1, '2006-04-22', 3),
(1, 2, 3, '2008-05-21', 5);

INSERT INTO storagedbscheme.supply_log (datesupl, rel_strg, rel_supl, rel_material, material_quantity)
VALUES
('2003-05-23', 1, 1, 1, 6),
('2009-07-21', 2, 2, 3, 5);

CREATE VIEW stored_material_veiw AS 
SELECT storages.address AS address,
material.name AS material,
stored_material_info.material_quantity AS mat_q
FROM storagedbscheme.stored_material_info
INNER JOIN storagedbscheme.material ON stored_material_info.material_related = material.id
INNER JOIN storagedbscheme.storages ON stored_material_info.storage_related = storages.id;

CREATE VIEW supply_logs_view AS
SELECT supply_log.datesupl AS date, 
suppliers.name AS supplier,
material.name AS material,
storages.address AS storage,
supply_log.material_quantity AS mat_q
FROM storagedbscheme.supply_log
INNER JOIN storagedbscheme.material ON supply_log.rel_material = material.id
INNER JOIN storagedbscheme.storages ON supply_log.rel_strg = storages.id
INNER JOIN storagedbscheme.suppliers ON supply_log.rel_supl = suppliers.id;

CREATE VIEW request_logs_view AS
SELECT decrease_log.daterequest AS date,
requestors.name AS requestor,
material.name AS material,
storages.address AS storage,
decrease_log.material_quantity AS mat_q
FROM storagedbscheme.decrease_log
INNER JOIN storagedbscheme.material ON decrease_log.rel_material = material.id
INNER JOIN storagedbscheme.storages ON decrease_log.rel_strg = storages.id
INNER JOIN storagedbscheme.requestors ON decrease_log.rel_req = requestors.id;
