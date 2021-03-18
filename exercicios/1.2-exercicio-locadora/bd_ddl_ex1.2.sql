CREATE DATABASE Locadora;

USE Pessoas;

CREATE TABLE Empresa
(
	idEmpresa INT PRIMARY KEY IDENTITY,
	Endereco	 VARCHAR(255),
	DonoDaEmpresa	 VARCHAR(255),


);


CREATE TABLE Veículo
(
	idVeiculo	INT PRIMARY KEY IDENTITY,
	idEmpresa	INT FOREIGN KEY REFERENCES Pessoa(idPessoa),
	Placa		VARCHAR(9) NOT NULL,
	AnoDeLancamento		VARCHAR(20) NOT NULL,
);


CREATE TABLE Cliente
(
	idCliente		INT PRIMARY KEY IDENTITY,
	idEmpresa	INT FOREIGN KEY REFERENCES Pessoa(idPessoa),
	Nome	VARCHAR(100) NOT NULL,
	ModeloDoCarro		VARCHAR(15) NOT NULL,

);



