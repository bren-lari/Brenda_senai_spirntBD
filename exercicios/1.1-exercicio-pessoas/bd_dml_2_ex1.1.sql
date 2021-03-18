USE Pessoas;

INSERT INTO Pessoa(Nome, Idade)
VALUES		('Brenda', '17'),
			('Caio', '24'),
			('Manoela', '13');

INSERT INTO Telefone(idPessoa, Numero, Tipo)
VALUES			(1, '2552-7647', 'Residencial'),
				(2, '2552-7647', 'Residencial'),
				(3, '983007930', 'Celular');

INSERT INTO Email(idPessoa, Endereco, Senha)
VALUES		(1, 'brenda@gmail.com', '12345'),
			(2, 'caio@gmail.com', '678910'),
			(3, 'manoela@gmail.com', '1112131415');

INSERT INTO CNH(idPessoa, Numero)
VALUES		(1, 0000000),
			(2, 1111111),
			(3, 3333333);

