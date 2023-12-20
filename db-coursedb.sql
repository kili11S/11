--
-- PostgreSQL database dump
--

-- Dumped from database version 16.0
-- Dumped by pg_dump version 16.0

-- Started on 2023-12-20 18:31:59

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
-- TOC entry 6 (class 2615 OID 16955)
-- Name: storageinfo; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA storageinfo;


ALTER SCHEMA storageinfo OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 228 (class 1259 OID 17044)
-- Name: decrease_log; Type: TABLE; Schema: storageinfo; Owner: postgres
--

CREATE TABLE storageinfo.decrease_log (
    id integer NOT NULL,
    rel_req integer,
    rel_strg integer,
    rel_material integer,
    daterequest date NOT NULL,
    material_quant integer NOT NULL
);


ALTER TABLE storageinfo.decrease_log OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 17043)
-- Name: decrease_log_id_seq; Type: SEQUENCE; Schema: storageinfo; Owner: postgres
--

ALTER TABLE storageinfo.decrease_log ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storageinfo.decrease_log_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 216 (class 1259 OID 16956)
-- Name: material; Type: TABLE; Schema: storageinfo; Owner: postgres
--

CREATE TABLE storageinfo.material (
    id integer NOT NULL,
    name text NOT NULL,
    mass integer NOT NULL,
    cubicmetres integer NOT NULL
);


ALTER TABLE storageinfo.material OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 17036)
-- Name: requestor; Type: TABLE; Schema: storageinfo; Owner: postgres
--

CREATE TABLE storageinfo.requestor (
    id integer NOT NULL,
    name text NOT NULL,
    contacts text NOT NULL
);


ALTER TABLE storageinfo.requestor OWNER TO postgres;

--
-- TOC entry 225 (class 1259 OID 17035)
-- Name: requestor_id_seq; Type: SEQUENCE; Schema: storageinfo; Owner: postgres
--

ALTER TABLE storageinfo.requestor ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storageinfo.requestor_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 218 (class 1259 OID 16964)
-- Name: storages; Type: TABLE; Schema: storageinfo; Owner: postgres
--

CREATE TABLE storageinfo.storages (
    id integer NOT NULL,
    address text NOT NULL,
    sizemetres integer NOT NULL
);


ALTER TABLE storageinfo.storages OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16963)
-- Name: storages_id_seq; Type: SEQUENCE; Schema: storageinfo; Owner: postgres
--

ALTER TABLE storageinfo.storages ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storageinfo.storages_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 220 (class 1259 OID 16972)
-- Name: stored_material_info; Type: TABLE; Schema: storageinfo; Owner: postgres
--

CREATE TABLE storageinfo.stored_material_info (
    id integer NOT NULL,
    storage_related integer,
    material_related integer,
    material_quantity integer NOT NULL
);


ALTER TABLE storageinfo.stored_material_info OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16971)
-- Name: stored_material_info_id_seq; Type: SEQUENCE; Schema: storageinfo; Owner: postgres
--

ALTER TABLE storageinfo.stored_material_info ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storageinfo.stored_material_info_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 222 (class 1259 OID 16996)
-- Name: suppliers; Type: TABLE; Schema: storageinfo; Owner: postgres
--

CREATE TABLE storageinfo.suppliers (
    id integer NOT NULL,
    name text NOT NULL,
    contacts text NOT NULL,
    supplied_mat integer
);


ALTER TABLE storageinfo.suppliers OWNER TO postgres;

--
-- TOC entry 221 (class 1259 OID 16995)
-- Name: suppliers_id_seq; Type: SEQUENCE; Schema: storageinfo; Owner: postgres
--

ALTER TABLE storageinfo.suppliers ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storageinfo.suppliers_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 224 (class 1259 OID 17015)
-- Name: supply_log; Type: TABLE; Schema: storageinfo; Owner: postgres
--

CREATE TABLE storageinfo.supply_log (
    id integer NOT NULL,
    datesupl date NOT NULL,
    rel_strg integer,
    rel_supl integer,
    rel_mat integer,
    mat_quant integer NOT NULL
);


ALTER TABLE storageinfo.supply_log OWNER TO postgres;

--
-- TOC entry 223 (class 1259 OID 17014)
-- Name: supply_log_id_seq; Type: SEQUENCE; Schema: storageinfo; Owner: postgres
--

ALTER TABLE storageinfo.supply_log ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME storageinfo.supply_log_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- TOC entry 4842 (class 0 OID 17044)
-- Dependencies: 228
-- Data for Name: decrease_log; Type: TABLE DATA; Schema: storageinfo; Owner: postgres
--

COPY storageinfo.decrease_log (id, rel_req, rel_strg, rel_material, daterequest, material_quant) FROM stdin;
\.


--
-- TOC entry 4830 (class 0 OID 16956)
-- Dependencies: 216
-- Data for Name: material; Type: TABLE DATA; Schema: storageinfo; Owner: postgres
--

COPY storageinfo.material (id, name, mass, cubicmetres) FROM stdin;
\.


--
-- TOC entry 4840 (class 0 OID 17036)
-- Dependencies: 226
-- Data for Name: requestor; Type: TABLE DATA; Schema: storageinfo; Owner: postgres
--

COPY storageinfo.requestor (id, name, contacts) FROM stdin;
\.


--
-- TOC entry 4832 (class 0 OID 16964)
-- Dependencies: 218
-- Data for Name: storages; Type: TABLE DATA; Schema: storageinfo; Owner: postgres
--

COPY storageinfo.storages (id, address, sizemetres) FROM stdin;
\.


--
-- TOC entry 4834 (class 0 OID 16972)
-- Dependencies: 220
-- Data for Name: stored_material_info; Type: TABLE DATA; Schema: storageinfo; Owner: postgres
--

COPY storageinfo.stored_material_info (id, storage_related, material_related, material_quantity) FROM stdin;
\.


--
-- TOC entry 4836 (class 0 OID 16996)
-- Dependencies: 222
-- Data for Name: suppliers; Type: TABLE DATA; Schema: storageinfo; Owner: postgres
--

COPY storageinfo.suppliers (id, name, contacts, supplied_mat) FROM stdin;
\.


--
-- TOC entry 4838 (class 0 OID 17015)
-- Dependencies: 224
-- Data for Name: supply_log; Type: TABLE DATA; Schema: storageinfo; Owner: postgres
--

COPY storageinfo.supply_log (id, datesupl, rel_strg, rel_supl, rel_mat, mat_quant) FROM stdin;
\.


--
-- TOC entry 4848 (class 0 OID 0)
-- Dependencies: 227
-- Name: decrease_log_id_seq; Type: SEQUENCE SET; Schema: storageinfo; Owner: postgres
--

SELECT pg_catalog.setval('storageinfo.decrease_log_id_seq', 1, false);


--
-- TOC entry 4849 (class 0 OID 0)
-- Dependencies: 225
-- Name: requestor_id_seq; Type: SEQUENCE SET; Schema: storageinfo; Owner: postgres
--

SELECT pg_catalog.setval('storageinfo.requestor_id_seq', 1, false);


--
-- TOC entry 4850 (class 0 OID 0)
-- Dependencies: 217
-- Name: storages_id_seq; Type: SEQUENCE SET; Schema: storageinfo; Owner: postgres
--

SELECT pg_catalog.setval('storageinfo.storages_id_seq', 1, false);


--
-- TOC entry 4851 (class 0 OID 0)
-- Dependencies: 219
-- Name: stored_material_info_id_seq; Type: SEQUENCE SET; Schema: storageinfo; Owner: postgres
--

SELECT pg_catalog.setval('storageinfo.stored_material_info_id_seq', 1, false);


--
-- TOC entry 4852 (class 0 OID 0)
-- Dependencies: 221
-- Name: suppliers_id_seq; Type: SEQUENCE SET; Schema: storageinfo; Owner: postgres
--

SELECT pg_catalog.setval('storageinfo.suppliers_id_seq', 1, false);


--
-- TOC entry 4853 (class 0 OID 0)
-- Dependencies: 223
-- Name: supply_log_id_seq; Type: SEQUENCE SET; Schema: storageinfo; Owner: postgres
--

SELECT pg_catalog.setval('storageinfo.supply_log_id_seq', 1, false);


--
-- TOC entry 4677 (class 2606 OID 17048)
-- Name: decrease_log decrease_log_pkey; Type: CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.decrease_log
    ADD CONSTRAINT decrease_log_pkey PRIMARY KEY (id);


--
-- TOC entry 4665 (class 2606 OID 16962)
-- Name: material material_pkey; Type: CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.material
    ADD CONSTRAINT material_pkey PRIMARY KEY (id);


--
-- TOC entry 4675 (class 2606 OID 17042)
-- Name: requestor requestor_pkey; Type: CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.requestor
    ADD CONSTRAINT requestor_pkey PRIMARY KEY (id);


--
-- TOC entry 4667 (class 2606 OID 16970)
-- Name: storages storages_pkey; Type: CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.storages
    ADD CONSTRAINT storages_pkey PRIMARY KEY (id);


--
-- TOC entry 4669 (class 2606 OID 16976)
-- Name: stored_material_info stored_material_info_pkey; Type: CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.stored_material_info
    ADD CONSTRAINT stored_material_info_pkey PRIMARY KEY (id);


--
-- TOC entry 4671 (class 2606 OID 17002)
-- Name: suppliers suppliers_pkey; Type: CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.suppliers
    ADD CONSTRAINT suppliers_pkey PRIMARY KEY (id);


--
-- TOC entry 4673 (class 2606 OID 17019)
-- Name: supply_log supply_log_pkey; Type: CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.supply_log
    ADD CONSTRAINT supply_log_pkey PRIMARY KEY (id);


--
-- TOC entry 4681 (class 2606 OID 17025)
-- Name: supply_log fk_mat; Type: FK CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.supply_log
    ADD CONSTRAINT fk_mat FOREIGN KEY (rel_mat) REFERENCES storageinfo.material(id);


--
-- TOC entry 4680 (class 2606 OID 17003)
-- Name: suppliers fk_material; Type: FK CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.suppliers
    ADD CONSTRAINT fk_material FOREIGN KEY (supplied_mat) REFERENCES storageinfo.material(id);


--
-- TOC entry 4684 (class 2606 OID 17059)
-- Name: decrease_log fk_material; Type: FK CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.decrease_log
    ADD CONSTRAINT fk_material FOREIGN KEY (rel_material) REFERENCES storageinfo.material(id);


--
-- TOC entry 4685 (class 2606 OID 17049)
-- Name: decrease_log fk_requestor; Type: FK CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.decrease_log
    ADD CONSTRAINT fk_requestor FOREIGN KEY (rel_req) REFERENCES storageinfo.requestor(id);


--
-- TOC entry 4682 (class 2606 OID 17030)
-- Name: supply_log fk_strg; Type: FK CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.supply_log
    ADD CONSTRAINT fk_strg FOREIGN KEY (rel_strg) REFERENCES storageinfo.storages(id);


--
-- TOC entry 4686 (class 2606 OID 17054)
-- Name: decrease_log fk_strg; Type: FK CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.decrease_log
    ADD CONSTRAINT fk_strg FOREIGN KEY (rel_strg) REFERENCES storageinfo.storages(id);


--
-- TOC entry 4683 (class 2606 OID 17020)
-- Name: supply_log fk_supl; Type: FK CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.supply_log
    ADD CONSTRAINT fk_supl FOREIGN KEY (rel_supl) REFERENCES storageinfo.suppliers(id);


--
-- TOC entry 4678 (class 2606 OID 16982)
-- Name: stored_material_info material_fk; Type: FK CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.stored_material_info
    ADD CONSTRAINT material_fk FOREIGN KEY (material_related) REFERENCES storageinfo.material(id);


--
-- TOC entry 4679 (class 2606 OID 16977)
-- Name: stored_material_info storage_fk; Type: FK CONSTRAINT; Schema: storageinfo; Owner: postgres
--

ALTER TABLE ONLY storageinfo.stored_material_info
    ADD CONSTRAINT storage_fk FOREIGN KEY (storage_related) REFERENCES storageinfo.storages(id);


-- Completed on 2023-12-20 18:32:00

--
-- PostgreSQL database dump complete
--

