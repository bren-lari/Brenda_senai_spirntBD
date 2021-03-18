CREATE DATABASE Pclinics;

CREATE TABLE Clinica
(
	idClinica	INT PRIMARY KEY IDENTITY,
	Endereco	VARCHAR(50) NOT NULL,
);

CREATE TABLE Veterinarios
(
	idVeterinario	INT PRIMARY KEY IDENTITY,
	idClinica		INT FOREIGN KEY REFERENCES Clinica(idClinica),
	Nome			VARCHAR(30) NOT NULL,
	Idade			INT,
);

CREATE TABLE Pets
(
	idPets	INT PRIMARY KEY IDENTITY,
	idClinica	INT FOREIGN KEY REFERENCES Clinica(idClinica),
	Especie		VARCHAR(50) NOT NULL,
);