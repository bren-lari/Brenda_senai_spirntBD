CREATE DATABASE Senai_SPMEDI_Tarde;

USE Senai_SPMEDI_Tarde;

CREATE TABLE Usuario
(
	idUsuario INT PRIMARY KEY IDENTITY,
	Nome	  VARCHAR(100),
	Email	  VARCHAR(100),
	Senha	  VARCHAR(100),
);

CREATE TABLE tipoUsuario
(
	idTipoUsuario	INT PRIMARY KEY IDENTITY,
	idUsuario		INT FOREIGN KEY REFERENCES Usuario(idUsuario),
	tituloTipoUsuario	VARCHAR(100),
);


CREATE TABLE Medico
(
	idMedico	INT PRIMARY KEY IDENTITY,
	Nome		VARCHAR(100),
	Email		VARCHAR(100),
	Senha		VARCHAR(100),
	EspecialidadeDeterminada	VARCHAR(100),
);


CREATE TABLE Clinica
(
	idClinica	INT PRIMARY KEY IDENTITY,
	Endereco	VARCHAR(100),
	HorarioDeFuncionamento	VARCHAR(100),
	CNPJ	VARCHAR(30),
); 

CREATE TABLE Consulta
(
	idConsulta	INT PRIMARY KEY IDENTITY,
	idUsuario	INT FOREIGN KEY REFERENCES Usuario(idUsuario),
	DataConsulta	VARCHAR(100),
	Situação	VARCHAR(100),
);


CREATE TABLE Especialidade
(
	idEspecialidade	INT PRIMARY KEY IDENTITY,
	idUsuario	 INT FOREIGN KEY REFERENCES	Usuario(idUsuario),
	NomeEspecialidade	VARCHAR(100),
);


CREATE TABLE Paciente
(
	idPaciente	 INT PRIMARY KEY IDENTITY,
	idConsulta	 INT FOREIGN KEY REFERENCES Consulta(idConsulta),
	Nome		 VARCHAR(100),
);