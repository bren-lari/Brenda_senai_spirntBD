CREATE DATABASE SENAI_hroads

USE SENAI_hroads

CREATE TABLE Classe
(
	idClasse INT PRIMARY KEY IDENTITY ,
	Nome VARCHAR(200) NOT NULL
);

CREATE TABLE TipoHabilidade
(
	idTipoHabilidade INT PRIMARY KEY IDENTITY ,
	Descricao VARCHAR (200) NOT NULL
);
CREATE TABLE Habilidade
(
	idHabilidade INT PRIMARY KEY IDENTITY ,
	idTipoHabilidade INT FOREIGN KEY REFERENCES TipoHabilidade (idTipoHabilidade),
	Nome VARCHAR (200) NOT NULL 
);

CREATE TABLE ClasseHabilidade
(
	idClasse INT FOREIGN KEY REFERENCES Classe(idClasse),
	idHabilidade INT FOREIGN KEY REFERENCES Habilidade (idHabilidade)

);
CREATE TABLE Personagem 
(
	idPersonagem INT PRIMARY KEy IDENTITY,
	idClasse INT FOREIGN  KEY REFERENCES Classe(idClasse),
	Nome VARCHAR (200) NOT NULL,
	MaxVida INT NOT NULL,
	MaxMana INT NOT NULL,
	DataAtt DATE NOT NULL,
	DataCriacao DATE NOT NULL
);