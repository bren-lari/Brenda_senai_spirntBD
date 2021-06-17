USE Pessoas;

INSERT INTO Pessoa(Nome, Idade)
VALUES		('Brenda', 17),
			('Caio', 14),
			('Manoela', 13);

INSERT INTO  Telefone(idPessoa, Numero, Tipo)
VALUES	     (1, '2552-7647', 'Residencial'),
			 (2, '2445-7898', 'Residencial'),
			 (3, '2245-3069', 'Residencial');

INSERT INTO Email(idPessoa, Endereco, Senha)
VALUES		(1, 'brenda@gmail.com', '12345'),
			(2, 'caio@gmail.com', '678910'),
			(3, 'manoel@gmail.com', '112131415');

INSERT INTO CNH(idPessoa, Numero)
VALUES			(1, '000000-0'),
				(2, '111111-1'),
				(3, '222222-2');




