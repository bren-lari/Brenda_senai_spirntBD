CREATE DATABASE Senai_Hroads_Tarde;

USE Senai_Hroads_Tarde;

CREATE TABLE Classes
(
	idClasse INT PRIMARY KEY IDENTITY,
	NomeClasse VARCHAR(50),
);

CREATE TABLE TiposHabilidades
(
	idTiposHabilidades	INT PRIMARY KEY IDENTITY,
	Tipo	VARCHAR(55) NOT NULL,

);


CREATE TABLE Habilidades
(
	idHabilidade INT PRIMARY KEY IDENTITY,
	idTiposHabilidades INT FOREIGN KEY REFERENCES TiposHabilidades(idTiposHabilidades),
	NomeHabilidade VARCHAR(50) NOT NULL,

);


CREATE TABLE ClassesHabilidades
(
	idClasse	INT FOREIGN KEY REFERENCES Classes(idClasse),
	idHabilidade INT FOREIGN KEY REFERENCES Habilidades(idHabilidade),
);

CREATE TABLE Personagens
(
	idPersonagem	INT PRIMARY KEY IDENTITY,
	idClasse	INT FOREIGN KEY REFERENCES Classes(idClasse),
	Nome		VARCHAR(50) NOT NULL,
	PVMaximo	INT,
	ManaMaxima	INT,
	DataAtt		VARCHAR(20) NOT NULL,
	DataCr		VARCHAR(20) NOT NULL,
);