CREATE DATABASE inlock_games_tarde;


USE inlock_games_tarde;


CREATE TABLE Estudios
(
	idEstudio INT PRIMARY KEY IDENTITY,
	nomeEstudio		VARCHAR(250) UNIQUE NOT NULL,
);



CREATE TABLE Jogos
(
	idJogos INT PRIMARY KEY IDENTITY,
	nomeJogo VARCHAR(250) NOT NULL,
	descricaoJogo TEXT NOT NULL,
	dataDeLancamento DATE NOT NULL,
	valor  DECIMAL (18,2) NOT NULL,
	idEstudio INT FOREIGN KEY REFERENCES Estudios(idEstudio),
);


CREATE TABLE tiposUsuarios
(
	idTipoUsuario INT PRIMARY KEY IDENTITY,
	tituloUsuario VARCHAR(250),
);


CREATE TABLE Usuarios
(
	idUsuario INT PRIMARY KEY IDENTITY,
	email VARCHAR(250) NOT NULL,
	senha VARCHAR(250) NOT NULL,
	idTipoUsuario INT FOREIGN KEY REFERENCES tiposUsuarios(idTipoUsuario),
);
