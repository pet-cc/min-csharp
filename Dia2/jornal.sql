DROP DATABASE IF EXISTS jornal;
CREATE DATABASE IF NOT EXISTS jornal;
USE jornal;

DROP TABLE IF EXISTS cidade,
                     categoria,
                     autor,
                     noticia;

CREATE TABLE cidade(
    CID_ID   int NOT NULL AUTO_INCREMENT,
    CID_NOME varchar(255) NOT NULL ,
    CID_UF   varchar(2) NOT NULL ,

    PRIMARY KEY (CID_ID));

CREATE TABLE categoria(
    CAT_ID   int NOT NULL AUTO_INCREMENT,
    CAT_NOME varchar(255) NOT NULL ,

    PRIMARY KEY (CAT_ID));

CREATE TABLE autor(
    AUT_ID    int NOT NULL AUTO_INCREMENT,
    AUT_NOME  varchar(255) NOT NULL,
    AUT_IDADE int NULL,
    CID_ID    int NULL,

    PRIMARY KEY (AUT_ID),
    FOREIGN KEY (CID_ID) REFERENCES cidade (CID_ID) ON DELETE CASCADE);

CREATE TABLE noticia(
    NOT_ID     int NOT NULL AUTO_INCREMENT,
    NOT_TITULO varchar(255) NOT NULL ,
    NOT_TEXTO  text NULL ,
    NOT_DATA   date NOT NULL ,
    AUT_ID     int NULL ,
    CAT_ID     int NULL ,

PRIMARY KEY (NOT_ID),
FOREIGN KEY (AUT_ID) REFERENCES autor (AUT_ID) ON DELETE CASCADE,
FOREIGN KEY (CAT_ID) REFERENCES categoria (CAT_ID) ON DELETE CASCADE);