USE Pclinics;

INSERT INTO Clinica(Endereco)
VALUES		('R.João Lourenço, 334'),
			('R.João Lourenço, 334');

INSERT INTO Veterinarios(idClinica, Nome, Idade)
VALUES			(1, 'Cláudio Manoel', 31),
				(2, 'Rafaela Monlargd', 28);

INSERT INTO Pets(idClinica, Especie)
VALUES		(1, 'Cachorro'),
			(2, 'Gato');
