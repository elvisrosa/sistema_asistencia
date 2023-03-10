PGDMP         2                {            MARCASIS_ASISTENCIA    10.21    10.21 *               0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false                       1262    33335    MARCASIS_ASISTENCIA    DATABASE     ?   CREATE DATABASE "MARCASIS_ASISTENCIA" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Spanish_Ecuador.1252' LC_CTYPE = 'Spanish_Ecuador.1252';
 %   DROP DATABASE "MARCASIS_ASISTENCIA";
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false                       0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    3                        3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false                       0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1            ?            1259    49734    asistencia_diaria    TABLE       CREATE TABLE public.asistencia_diaria (
    idasistencia integer NOT NULL,
    identi_persona character(10),
    observacion character(150),
    horas numeric,
    estado character(10),
    fecha date,
    horaentrada timestamp with time zone,
    horasalida timestamp with time zone
);
 %   DROP TABLE public.asistencia_diaria;
       public         postgres    false    3            ?            1259    49732 "   asistencia_diaria_idasistencia_seq    SEQUENCE     ?   CREATE SEQUENCE public.asistencia_diaria_idasistencia_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public.asistencia_diaria_idasistencia_seq;
       public       postgres    false    3    201                       0    0 "   asistencia_diaria_idasistencia_seq    SEQUENCE OWNED BY     i   ALTER SEQUENCE public.asistencia_diaria_idasistencia_seq OWNED BY public.asistencia_diaria.idasistencia;
            public       postgres    false    200            ?            1259    33346    cargo    TABLE     n   CREATE TABLE public.cargo (
    id integer NOT NULL,
    sueldohora numeric,
    nombrecargo character(50)
);
    DROP TABLE public.cargo;
       public         postgres    false    3            ?            1259    33344    cargo_id_seq    SEQUENCE     ?   CREATE SEQUENCE public.cargo_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.cargo_id_seq;
       public       postgres    false    3    197                       0    0    cargo_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.cargo_id_seq OWNED BY public.cargo.id;
            public       postgres    false    196            ?            1259    33357    personal    TABLE     ?   CREATE TABLE public.personal (
    nombres character(50),
    pais character(100),
    idcargo integer,
    estado character(10),
    codigo integer NOT NULL,
    identificacion character(10) NOT NULL
);
    DROP TABLE public.personal;
       public         postgres    false    3            ?            1259    33355    personal_codigo_seq    SEQUENCE     ?   CREATE SEQUENCE public.personal_codigo_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.personal_codigo_seq;
       public       postgres    false    3    199                       0    0    personal_codigo_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.personal_codigo_seq OWNED BY public.personal.codigo;
            public       postgres    false    198            ?            1259    49765    usuario    TABLE     ?   CREATE TABLE public.usuario (
    idusuario integer NOT NULL,
    contrasena character(15) NOT NULL,
    tipo character(10) NOT NULL,
    identificacionpersonal character(10)
);
    DROP TABLE public.usuario;
       public         postgres    false    3            ?            1259    49763    usuario_idusuario_seq    SEQUENCE     ?   CREATE SEQUENCE public.usuario_idusuario_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.usuario_idusuario_seq;
       public       postgres    false    3    203                        0    0    usuario_idusuario_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.usuario_idusuario_seq OWNED BY public.usuario.idusuario;
            public       postgres    false    202            ?
           2604    49737    asistencia_diaria idasistencia    DEFAULT     ?   ALTER TABLE ONLY public.asistencia_diaria ALTER COLUMN idasistencia SET DEFAULT nextval('public.asistencia_diaria_idasistencia_seq'::regclass);
 M   ALTER TABLE public.asistencia_diaria ALTER COLUMN idasistencia DROP DEFAULT;
       public       postgres    false    201    200    201            ?
           2604    33349    cargo id    DEFAULT     d   ALTER TABLE ONLY public.cargo ALTER COLUMN id SET DEFAULT nextval('public.cargo_id_seq'::regclass);
 7   ALTER TABLE public.cargo ALTER COLUMN id DROP DEFAULT;
       public       postgres    false    197    196    197            ?
           2604    33360    personal codigo    DEFAULT     r   ALTER TABLE ONLY public.personal ALTER COLUMN codigo SET DEFAULT nextval('public.personal_codigo_seq'::regclass);
 >   ALTER TABLE public.personal ALTER COLUMN codigo DROP DEFAULT;
       public       postgres    false    198    199    199            ?
           2604    49768    usuario idusuario    DEFAULT     v   ALTER TABLE ONLY public.usuario ALTER COLUMN idusuario SET DEFAULT nextval('public.usuario_idusuario_seq'::regclass);
 @   ALTER TABLE public.usuario ALTER COLUMN idusuario DROP DEFAULT;
       public       postgres    false    202    203    203                      0    49734    asistencia_diaria 
   TABLE DATA               ?   COPY public.asistencia_diaria (idasistencia, identi_persona, observacion, horas, estado, fecha, horaentrada, horasalida) FROM stdin;
    public       postgres    false    201   ?-                 0    33346    cargo 
   TABLE DATA               <   COPY public.cargo (id, sueldohora, nombrecargo) FROM stdin;
    public       postgres    false    197   ?1                 0    33357    personal 
   TABLE DATA               Z   COPY public.personal (nombres, pais, idcargo, estado, codigo, identificacion) FROM stdin;
    public       postgres    false    199   72                 0    49765    usuario 
   TABLE DATA               V   COPY public.usuario (idusuario, contrasena, tipo, identificacionpersonal) FROM stdin;
    public       postgres    false    203   65       !           0    0 "   asistencia_diaria_idasistencia_seq    SEQUENCE SET     R   SELECT pg_catalog.setval('public.asistencia_diaria_idasistencia_seq', 100, true);
            public       postgres    false    200            "           0    0    cargo_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.cargo_id_seq', 12, true);
            public       postgres    false    196            #           0    0    personal_codigo_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.personal_codigo_seq', 40, true);
            public       postgres    false    198            $           0    0    usuario_idusuario_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.usuario_idusuario_seq', 14, true);
            public       postgres    false    202            ?
           2606    49739 (   asistencia_diaria asistencia_diaria_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public.asistencia_diaria
    ADD CONSTRAINT asistencia_diaria_pkey PRIMARY KEY (idasistencia);
 R   ALTER TABLE ONLY public.asistencia_diaria DROP CONSTRAINT asistencia_diaria_pkey;
       public         postgres    false    201            ?
           2606    33354    cargo cargo_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.cargo
    ADD CONSTRAINT cargo_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.cargo DROP CONSTRAINT cargo_pkey;
       public         postgres    false    197            ?
           2606    41532    personal pk_identificacion 
   CONSTRAINT     d   ALTER TABLE ONLY public.personal
    ADD CONSTRAINT pk_identificacion PRIMARY KEY (identificacion);
 D   ALTER TABLE ONLY public.personal DROP CONSTRAINT pk_identificacion;
       public         postgres    false    199            ?
           2606    49770    usuario usuario_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (idusuario);
 >   ALTER TABLE ONLY public.usuario DROP CONSTRAINT usuario_pkey;
       public         postgres    false    203            ?
           1259    33375    fki_fk_idcargo    INDEX     F   CREATE INDEX fki_fk_idcargo ON public.personal USING btree (idcargo);
 "   DROP INDEX public.fki_fk_idcargo;
       public         postgres    false    199            ?
           1259    49776    fki_fk_identificacionpersonal    INDEX     c   CREATE INDEX fki_fk_identificacionpersonal ON public.usuario USING btree (identificacionpersonal);
 1   DROP INDEX public.fki_fk_identificacionpersonal;
       public         postgres    false    203            ?
           1259    49749    fki_fk_idpersonal    INDEX     Y   CREATE INDEX fki_fk_idpersonal ON public.asistencia_diaria USING btree (identi_persona);
 %   DROP INDEX public.fki_fk_idpersonal;
       public         postgres    false    201            ?
           2606    33370    personal fk_idcargo    FK CONSTRAINT     |   ALTER TABLE ONLY public.personal
    ADD CONSTRAINT fk_idcargo FOREIGN KEY (idcargo) REFERENCES public.cargo(id) NOT VALID;
 =   ALTER TABLE ONLY public.personal DROP CONSTRAINT fk_idcargo;
       public       postgres    false    2695    197    199            ?
           2606    49771 !   usuario fk_identificacionpersonal    FK CONSTRAINT     ?   ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT fk_identificacionpersonal FOREIGN KEY (identificacionpersonal) REFERENCES public.personal(identificacion) NOT VALID;
 K   ALTER TABLE ONLY public.usuario DROP CONSTRAINT fk_identificacionpersonal;
       public       postgres    false    199    2698    203            ?
           2606    49750    asistencia_diaria fk_idpersonal    FK CONSTRAINT     ?   ALTER TABLE ONLY public.asistencia_diaria
    ADD CONSTRAINT fk_idpersonal FOREIGN KEY (identi_persona) REFERENCES public.personal(identificacion) NOT VALID;
 I   ALTER TABLE ONLY public.asistencia_diaria DROP CONSTRAINT fk_idpersonal;
       public       postgres    false    199    201    2698               M  x?՘Kn#G???)? 3????? ??"?r6?? ?Y2?\+G???*?VK?????E?ٛO????KИ2??U??>?????w7??G?O]??Z8??As?:?r7?t??iѥ??A.?'?????t?z?~??????AG??*????H%p??s?Σ8$?????Mp????k?9x, ??+Qbi??~???&8Q?PB????nQ???KL?jy?y??~jSZ?g$??	x???}??Q+??2Q?&n???9{L@???Q??YrS\??ӄ??1?B/	_ (?> ?T'5?S?@e??R}?3????ܒa???&Ѭߓ??Or??x? ?0cS<4W??ܤS]?h??%3?9x????d?T?xq??f??v?,???\???u?????@br??t????[?$????m.}=?K??>L)غ????o?<+c??>Opl?2???\??????v?̓?6vs??}???m?,??????7?q;,?????~??????5-!ӕ??xF?;idj????9?-_?R?????`?FĄ????z???M?&?????JuJI????E?ڂ??? ?????a?}p?U???ݮ?Z??[?v???%?zx^???n??Jb?ٻ???,????~?[??uo?O?_r?s?`??ڒ?^,Ǳ????p???yٹ_?????s.?j??z??;ۺa
1??`?R??H>%&m?HNc??w??iA?I?ܯ??H?ߺ߳?.yc?Z?Y?6)????o]o%_H?S??9k	?QTA_Z?h???9?;4]l?)ڬ?g?֎?6]{B???v??޶"?\????V?*?Y?m?/~>??	/~_         ?   x???1r?0E??)t?r0!e.?QP???#??Id2?G??X֦Hت?????????]?놾?sGQ?:??]?ȟ??Ň?3Pͪ??(????K?ZL??
L!?k@/?G?r	?-nm>????]?LU?&Rr?L?}??R&}c?Bq???????hUO??>P?y.?(K0?????????W?H??n0??*?$??%????????y?,???{-????c??????         ?  x?͗?N?@Ư;O1O??ә??????U/???Ȏi;fJ??6^??؞?4?K?і???????;??u?yNUJ???T?V?/r??i??+??????Y????A?{???I?F?d:???@????d???-?9\??2?id??w˫簒	???٧"?GNA%??u錆?\?? ??ԐE???R%??,?e	?? ;??v?Шl? wo?S?Y7_?d???M??KM/??????j??S
?W*??%f??????}d6*P[iL ??5???rl?c?(??1\?Rͯ?>ʳ?b??~?Fcf??]nV?2?4?????????`̌Ubv?E?2??9$???D>2?!;8e???`d7??jc$БDy4?F7ȸq??E?	??j&G֐?0?1aC?`??;c?+C-?t??\?????#5gf?Ώ??,G???ׯ?){????e???]?.?{?lVf	?0]il?6?fM7?jѲ_????(?m???2?
???K?<?fT?ǭ#???≕??6??????y7??.sPM?&?6???u?{(sζep?쐟(b?֢?p??????WN?g?p2Ti?n?B?Ȟ5??LO~??36+?D??m2?Uao@Os|DAϘm????a? +???K???ޡf֣?CƉ?_Mp???t#V?F?????vk?|`??C??G?sw??ɓ??Q????ފ?Kˈ??BY??=??s=???%#????+H?M!?f???????R???7B???NW         ?   x?u?K?0DיSp?q>N??????AJi?H???73?CG	1e-U/?ܲ???4??h??T?3??B>Ţ-;?;??(T?y??!T竈z?;?!?SE?r???s7N?z{??!P????k2?")aLe?????ҩ?h?+???L?     