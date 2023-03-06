PGDMP     (                    {            MARCASIS_ASISTENCIA    10.21    10.21 !    	           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            
           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false                       1262    33335    MARCASIS_ASISTENCIA    DATABASE     �   CREATE DATABASE "MARCASIS_ASISTENCIA" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Spanish_Ecuador.1252' LC_CTYPE = 'Spanish_Ecuador.1252';
 %   DROP DATABASE "MARCASIS_ASISTENCIA";
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false                       0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    3                        3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false                       0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            �            1259    49734    asistencia_diaria    TABLE     �   CREATE TABLE public.asistencia_diaria (
    idasistencia integer NOT NULL,
    horaentrada timestamp with time zone NOT NULL,
    horasalida time without time zone NOT NULL,
    identi_persona character(1)
);
 %   DROP TABLE public.asistencia_diaria;
       public         postgres    false    3            �            1259    49732 "   asistencia_diaria_idasistencia_seq    SEQUENCE     �   CREATE SEQUENCE public.asistencia_diaria_idasistencia_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public.asistencia_diaria_idasistencia_seq;
       public       postgres    false    201    3                       0    0 "   asistencia_diaria_idasistencia_seq    SEQUENCE OWNED BY     i   ALTER SEQUENCE public.asistencia_diaria_idasistencia_seq OWNED BY public.asistencia_diaria.idasistencia;
            public       postgres    false    200            �            1259    33346    cargo    TABLE     n   CREATE TABLE public.cargo (
    id integer NOT NULL,
    sueldohora numeric,
    nombrecargo character(50)
);
    DROP TABLE public.cargo;
       public         postgres    false    3            �            1259    33344    cargo_id_seq    SEQUENCE     �   CREATE SEQUENCE public.cargo_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.cargo_id_seq;
       public       postgres    false    197    3                       0    0    cargo_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.cargo_id_seq OWNED BY public.cargo.id;
            public       postgres    false    196            �            1259    33357    personal    TABLE     �   CREATE TABLE public.personal (
    nombres character(50),
    pais character(100),
    idcargo integer,
    estado character(10),
    codigo integer NOT NULL,
    identificacion character(10) NOT NULL
);
    DROP TABLE public.personal;
       public         postgres    false    3            �            1259    33355    personal_codigo_seq    SEQUENCE     �   CREATE SEQUENCE public.personal_codigo_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.personal_codigo_seq;
       public       postgres    false    199    3                       0    0    personal_codigo_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.personal_codigo_seq OWNED BY public.personal.codigo;
            public       postgres    false    198            }
           2604    49737    asistencia_diaria idasistencia    DEFAULT     �   ALTER TABLE ONLY public.asistencia_diaria ALTER COLUMN idasistencia SET DEFAULT nextval('public.asistencia_diaria_idasistencia_seq'::regclass);
 M   ALTER TABLE public.asistencia_diaria ALTER COLUMN idasistencia DROP DEFAULT;
       public       postgres    false    200    201    201            {
           2604    33349    cargo id    DEFAULT     d   ALTER TABLE ONLY public.cargo ALTER COLUMN id SET DEFAULT nextval('public.cargo_id_seq'::regclass);
 7   ALTER TABLE public.cargo ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    196    197    197            |
           2604    33360    personal codigo    DEFAULT     r   ALTER TABLE ONLY public.personal ALTER COLUMN codigo SET DEFAULT nextval('public.personal_codigo_seq'::regclass);
 >   ALTER TABLE public.personal ALTER COLUMN codigo DROP DEFAULT;
       public       postgres    false    199    198    199                      0    49734    asistencia_diaria 
   TABLE DATA               b   COPY public.asistencia_diaria (idasistencia, horaentrada, horasalida, identi_persona) FROM stdin;
    public       postgres    false    201   �"                 0    33346    cargo 
   TABLE DATA               <   COPY public.cargo (id, sueldohora, nombrecargo) FROM stdin;
    public       postgres    false    197   �"                 0    33357    personal 
   TABLE DATA               Z   COPY public.personal (nombres, pais, idcargo, estado, codigo, identificacion) FROM stdin;
    public       postgres    false    199   �#                  0    0 "   asistencia_diaria_idasistencia_seq    SEQUENCE SET     Q   SELECT pg_catalog.setval('public.asistencia_diaria_idasistencia_seq', 1, false);
            public       postgres    false    200                       0    0    cargo_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.cargo_id_seq', 8, true);
            public       postgres    false    196                       0    0    personal_codigo_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.personal_codigo_seq', 11, true);
            public       postgres    false    198            �
           2606    49739 (   asistencia_diaria asistencia_diaria_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public.asistencia_diaria
    ADD CONSTRAINT asistencia_diaria_pkey PRIMARY KEY (idasistencia);
 R   ALTER TABLE ONLY public.asistencia_diaria DROP CONSTRAINT asistencia_diaria_pkey;
       public         postgres    false    201            
           2606    33354    cargo cargo_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.cargo
    ADD CONSTRAINT cargo_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.cargo DROP CONSTRAINT cargo_pkey;
       public         postgres    false    197            �
           2606    41532    personal pk_identificacion 
   CONSTRAINT     d   ALTER TABLE ONLY public.personal
    ADD CONSTRAINT pk_identificacion PRIMARY KEY (identificacion);
 D   ALTER TABLE ONLY public.personal DROP CONSTRAINT pk_identificacion;
       public         postgres    false    199            �
           1259    33375    fki_fk_idcargo    INDEX     F   CREATE INDEX fki_fk_idcargo ON public.personal USING btree (idcargo);
 "   DROP INDEX public.fki_fk_idcargo;
       public         postgres    false    199            �
           1259    49745    fki_fk_idpersonal    INDEX     Y   CREATE INDEX fki_fk_idpersonal ON public.asistencia_diaria USING btree (identi_persona);
 %   DROP INDEX public.fki_fk_idpersonal;
       public         postgres    false    201            �
           2606    33370    personal fk_idcargo    FK CONSTRAINT     |   ALTER TABLE ONLY public.personal
    ADD CONSTRAINT fk_idcargo FOREIGN KEY (idcargo) REFERENCES public.cargo(id) NOT VALID;
 =   ALTER TABLE ONLY public.personal DROP CONSTRAINT fk_idcargo;
       public       postgres    false    199    197    2687            �
           2606    49740    asistencia_diaria fk_idpersonal    FK CONSTRAINT     �   ALTER TABLE ONLY public.asistencia_diaria
    ADD CONSTRAINT fk_idpersonal FOREIGN KEY (identi_persona) REFERENCES public.personal(identificacion) NOT VALID;
 I   ALTER TABLE ONLY public.asistencia_diaria DROP CONSTRAINT fk_idpersonal;
       public       postgres    false    201    199    2690                  x������ � �         �   x���1�0�9=EN�dՇ���K-��'4�o�<�ʂ9_�&I!�A�uY���v�R+Ʋ�kt^���X@k#k�� �ti��F����Q`+�`g*2�,#��S�C�lO�kS��+�|&����4�|d���#��bH���.�I����IXg4���%2Ha��p�R�6�qG����	y�`�         �   x��)MN,V+�IO,��S p�&�&����l�i������pXX���q��e+�'*����W&'�!;��bCss3C.�Ԣ��<���ܤ�ļ|b���-�.6�4536��M,I�������������,9M�L��54������� �jwE     