USE inlock_games_tarde;

INSERT INTO Estudios(nomeEstudio)
VALUES				('Blizzard'),
					('Rockstar Studios'),
					('Square Enix');

INSERT INTO Jogos(nomeJogo, descricaoJogo, dataDeLancamento, valor,idEstudio)
VALUES			 ('Daiblo 3', 'É um jogo que contém bastante ação e é viciante, seja você um novato ou um fã.', '15/05/2012','99.00', '1'),
				 ('Red Dead Redemption II', 'Jogo eletrônico de ação-aventura western.', '26/10/2018', '120.00', '2');


INSERT INTO tiposUsuarios(tituloUsuario)
VALUES					('Administrador'),
						('Cliente');

INSERT INTO Usuarios(email, senha, idTipoUsuario)
VALUES				('admin@admin.com', 'admin', '1'),
					('cliente@cliente.com', 'cliente', '2');
				
