--
-- PostgreSQL database dump
--

-- Dumped from database version 16.0 (Debian 16.0-1.pgdg120+1)
-- Dumped by pg_dump version 16.0 (Debian 16.0-1.pgdg120+1)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: storagedbscheme; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA storagedbscheme;


ALTER SCHEMA storagedbscheme OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: decrease_log; Type: TABLE; Schema: storagedbscheme; Owner: postgres
--

CREATE TABLE storagedbscheme.decrease_log (
    id integer NOT NULL,
    rel_req integer,
    rel_strg integer,
    rel_material integer,
    daterequest date NOT NULL,
    material_quantity integer NOT NULL
);


ALTER TABLE storagedbscheme.decrease_log OWNER TO postgres;

--
-- Name: material; Type: TABLE; Schema: storagedbscheme; Owner: postgres
--

CREATE TABLE storagedbscheme.material (
    id integer NOT NULL,
    name text NOT NULL,
    mass integer NOT NULL,
    cubicmetres integer NOT NULL
);


ALTER TABLE storagedbscheme.material OWNER TO postgres;

--
-- Name: requestors; Type: TABLE; Schema: storagedbscheme; Owner: postgres
--

CREATE TABLE storagedbscheme.requestors (
    id integer NOT NULL,
    name text NOT NULL,
    contacts text NOT NULL
);


ALTER TABLE storagedbscheme.requestors OWNER TO postgres;

--
-- Name: storages; Type: TABLE; Schema: storagedbscheme; Owner: postgres
--

CREATE TABLE storagedbscheme.storages (
    id integer NOT NULL,
    address text NOT NULL,
    sizemetres integer NOT NULL
);


ALTER TABLE storagedbscheme.storages OWNER TO postgres;

--
-- Name: request_logs_view; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.request_logs_view AS
 SELECT decrease_log.daterequest AS date,
    requestors.name AS requestor,
    material.name AS material,
    storages.address AS storage,
    decrease_log.material_quantity AS mat_q
   FROM (((storagedbscheme.decrease_log
     JOIN storagedbscheme.material ON ((decrease_log.rel_material = material.id)))
     JOIN storagedbscheme.storages ON ((decrease_log.rel_strg = storages.id)))
     JOIN storagedbscheme.requestors ON ((decrease_log.rel_req = requestors.id)));


ALTER VIEW public.request_logs_view OWNER TO postgres;

--
-- Name: stored_material_info; Type: TABLE; Schema: storagedbscheme; Owner: postgres
--

CREATE TABLE storagedbscheme.stored_material_info (
    id integer NOT NULL,
    storage_related integer,
    material_related integer,
    material_quantity integer NOT NULL
);


ALTER TABLE storagedbscheme.stored_material_info OWNER TO postgres;

--
-- Name: stored_material_veiw; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.stored_material_veiw AS
 SELECT storages.address,
    material.name AS material,
    stored_material_info.material_quantity AS mat_q
   FROM ((storagedbscheme.stored_material_info
     JOIN storagedbscheme.material ON ((stored_material_info.material_related = material.id)))
     JOIN storagedbscheme.storages ON ((stored_material_info.storage_related = storages.id)));


ALTER VIEW public.stored_material_veiw OWNER TO postgres;

--
-- Name: suppliers; Type: TABLE; Schema: storagedbscheme; Owner: postgres
--

CREATE TABLE storagedbscheme.suppliers (
    id integer NOT NULL,
    name text NOT NULL,
    contacts text NOT NULL,
    supplied_mat integer
);


ALTER TABLE storagedbscheme.suppliers OWNER TO postgres;

--
-- Name: supply_log; Type: TABLE; Schema: storagedbscheme; Owner: postgres
--

CREATE TABLE storagedbscheme.supply_log (
    id integer NOT NULL,
    datesupl date NOT NULL,
    rel_strg integer,
    rel_supl integer,
    rel_material integer,
    material_quantity integer NOT NULL
);


ALTER TABLE storagedbscheme.supply_log OWNER TO postgres;

--
-- Name: supply_logs_view; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW public.supply_logs_view AS
 SELECT supply_log.datesupl AS date,
    suppliers.name AS supplier,
    material.name AS material,
    storages.address AS storage,
    supply_log.material_quantity AS mat_q
   FROM (((storagedbscheme.supply_log
     JOIN storagedbscheme.material ON ((supply_log.rel_material = material.id)))
     JOIN storagedbscheme.storages ON ((supply_log.rel_strg = storages.id)))
     JOIN storagedbscheme.suppliers ON ((supply_log.rel_supl = suppliers.id)));


ALTER VIEW public.supply_logs_view OWNER TO postgres;

--
-- Name: decrease_log_id_seq; Type: SEQUENCE; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE storagedbscheme.decrease_log ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storagedbscheme.decrease_log_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: material_id_seq; Type: SEQUENCE; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE storagedbscheme.material ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storagedbscheme.material_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: requestors_id_seq; Type: SEQUENCE; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE storagedbscheme.requestors ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storagedbscheme.requestors_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: storages_id_seq; Type: SEQUENCE; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE storagedbscheme.storages ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storagedbscheme.storages_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: stored_material_info_id_seq; Type: SEQUENCE; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE storagedbscheme.stored_material_info ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storagedbscheme.stored_material_info_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: suppliers_id_seq; Type: SEQUENCE; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE storagedbscheme.suppliers ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storagedbscheme.suppliers_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: supply_log_id_seq; Type: SEQUENCE; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE storagedbscheme.supply_log ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storagedbscheme.supply_log_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Data for Name: decrease_log; Type: TABLE DATA; Schema: storagedbscheme; Owner: postgres
--

COPY storagedbscheme.decrease_log (id, rel_req, rel_strg, rel_material, daterequest, material_quantity) FROM stdin;
1	1	1	2	2004-06-28	2
2	2	1	1	2006-04-22	3
3	1	2	3	2008-05-21	5
\.


--
-- Data for Name: material; Type: TABLE DATA; Schema: storagedbscheme; Owner: postgres
--

COPY storagedbscheme.material (id, name, mass, cubicmetres) FROM stdin;
1	Solid Wood	15	3
2	Iron	25	2
3	Stainless Steel	11	1
\.


--
-- Data for Name: requestors; Type: TABLE DATA; Schema: storagedbscheme; Owner: postgres
--

COPY storagedbscheme.requestors (id, name, contacts) FROM stdin;
1	Factory One	79913131213
2	Industry Two	79928123612
\.


--
-- Data for Name: storages; Type: TABLE DATA; Schema: storagedbscheme; Owner: postgres
--

COPY storagedbscheme.storages (id, address, sizemetres) FROM stdin;
1	Long Avenue 16	250
2	Short Alley 12	150
\.


--
-- Data for Name: stored_material_info; Type: TABLE DATA; Schema: storagedbscheme; Owner: postgres
--

COPY storagedbscheme.stored_material_info (id, storage_related, material_related, material_quantity) FROM stdin;
1	1	1	13
2	1	2	3
3	1	3	6
4	2	1	3
5	2	3	6
\.


--
-- Data for Name: suppliers; Type: TABLE DATA; Schema: storagedbscheme; Owner: postgres
--

COPY storagedbscheme.suppliers (id, name, contacts, supplied_mat) FROM stdin;
1	Ice Inc.	79213341312	2
2	Aley Co.	89223314561	1
\.


--
-- Data for Name: supply_log; Type: TABLE DATA; Schema: storagedbscheme; Owner: postgres
--

COPY storagedbscheme.supply_log (id, datesupl, rel_strg, rel_supl, rel_material, material_quantity) FROM stdin;
1	2003-05-23	1	1	1	6
2	2009-07-21	2	2	3	5
\.


--
-- Name: decrease_log_id_seq; Type: SEQUENCE SET; Schema: storagedbscheme; Owner: postgres
--

SELECT pg_catalog.setval('storagedbscheme.decrease_log_id_seq', 3, true);


--
-- Name: material_id_seq; Type: SEQUENCE SET; Schema: storagedbscheme; Owner: postgres
--

SELECT pg_catalog.setval('storagedbscheme.material_id_seq', 3, true);


--
-- Name: requestors_id_seq; Type: SEQUENCE SET; Schema: storagedbscheme; Owner: postgres
--

SELECT pg_catalog.setval('storagedbscheme.requestors_id_seq', 2, true);


--
-- Name: storages_id_seq; Type: SEQUENCE SET; Schema: storagedbscheme; Owner: postgres
--

SELECT pg_catalog.setval('storagedbscheme.storages_id_seq', 2, true);


--
-- Name: stored_material_info_id_seq; Type: SEQUENCE SET; Schema: storagedbscheme; Owner: postgres
--

SELECT pg_catalog.setval('storagedbscheme.stored_material_info_id_seq', 5, true);


--
-- Name: suppliers_id_seq; Type: SEQUENCE SET; Schema: storagedbscheme; Owner: postgres
--

SELECT pg_catalog.setval('storagedbscheme.suppliers_id_seq', 2, true);


--
-- Name: supply_log_id_seq; Type: SEQUENCE SET; Schema: storagedbscheme; Owner: postgres
--

SELECT pg_catalog.setval('storagedbscheme.supply_log_id_seq', 2, true);


--
-- Name: decrease_log decrease_log_pkey; Type: CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.decrease_log
    ADD CONSTRAINT decrease_log_pkey PRIMARY KEY (id);


--
-- Name: material material_pkey; Type: CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.material
    ADD CONSTRAINT material_pkey PRIMARY KEY (id);


--
-- Name: requestors requestors_pkey; Type: CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.requestors
    ADD CONSTRAINT requestors_pkey PRIMARY KEY (id);


--
-- Name: storages storages_pkey; Type: CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.storages
    ADD CONSTRAINT storages_pkey PRIMARY KEY (id);


--
-- Name: stored_material_info stored_material_info_pkey; Type: CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.stored_material_info
    ADD CONSTRAINT stored_material_info_pkey PRIMARY KEY (id);


--
-- Name: suppliers suppliers_pkey; Type: CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.suppliers
    ADD CONSTRAINT suppliers_pkey PRIMARY KEY (id);


--
-- Name: supply_log supply_log_pkey; Type: CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.supply_log
    ADD CONSTRAINT supply_log_pkey PRIMARY KEY (id);


--
-- Name: decrease_log decrease_log_rel_material_fkey; Type: FK CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.decrease_log
    ADD CONSTRAINT decrease_log_rel_material_fkey FOREIGN KEY (rel_material) REFERENCES storagedbscheme.material(id);


--
-- Name: decrease_log decrease_log_rel_req_fkey; Type: FK CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.decrease_log
    ADD CONSTRAINT decrease_log_rel_req_fkey FOREIGN KEY (rel_req) REFERENCES storagedbscheme.requestors(id);


--
-- Name: decrease_log decrease_log_rel_strg_fkey; Type: FK CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.decrease_log
    ADD CONSTRAINT decrease_log_rel_strg_fkey FOREIGN KEY (rel_strg) REFERENCES storagedbscheme.storages(id);


--
-- Name: stored_material_info stored_material_info_material_related_fkey; Type: FK CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.stored_material_info
    ADD CONSTRAINT stored_material_info_material_related_fkey FOREIGN KEY (material_related) REFERENCES storagedbscheme.material(id);


--
-- Name: stored_material_info stored_material_info_storage_related_fkey; Type: FK CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.stored_material_info
    ADD CONSTRAINT stored_material_info_storage_related_fkey FOREIGN KEY (storage_related) REFERENCES storagedbscheme.storages(id);


--
-- Name: suppliers suppliers_supplied_mat_fkey; Type: FK CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.suppliers
    ADD CONSTRAINT suppliers_supplied_mat_fkey FOREIGN KEY (supplied_mat) REFERENCES storagedbscheme.material(id);


--
-- Name: supply_log supply_log_rel_material_fkey; Type: FK CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.supply_log
    ADD CONSTRAINT supply_log_rel_material_fkey FOREIGN KEY (rel_material) REFERENCES storagedbscheme.material(id);


--
-- Name: supply_log supply_log_rel_strg_fkey; Type: FK CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.supply_log
    ADD CONSTRAINT supply_log_rel_strg_fkey FOREIGN KEY (rel_strg) REFERENCES storagedbscheme.storages(id);


--
-- Name: supply_log supply_log_rel_supl_fkey; Type: FK CONSTRAINT; Schema: storagedbscheme; Owner: postgres
--

ALTER TABLE ONLY storagedbscheme.supply_log
    ADD CONSTRAINT supply_log_rel_supl_fkey FOREIGN KEY (rel_supl) REFERENCES storagedbscheme.suppliers(id);


--
-- PostgreSQL database dump complete
--

