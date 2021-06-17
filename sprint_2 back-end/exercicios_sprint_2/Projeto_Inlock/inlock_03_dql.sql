USE inlock_games_tarde;

SELECT * FROM Estudios;

SELECT * FROM Jogos;

SELECT * FROM tiposUsuarios;

SELECT * FROM Usuarios;

SELECT Jogos.nomeJogo, Estudios.nomeEstudio FROM Jogos
LEFT JOIN Estudios
ON Estudios.idEstudio = Jogos.idEstudio;

SELECT Estudios.nomeEstudio, Jogos.nomeJogo FROM Estudios
LEFT JOIN Jogos
ON Jogos.idEstudio = Estudios.idEstudio;

SELECT Usuarios.email, Usuarios.senha FROM Usuarios
WHERE email LIKE '%.com%';

SELECT Jogos.nomeJogo, Jogos.idJogos FROM Jogos
WHERE idJogos = '2';

SELECT Estudios.nomeEstudio, Estudios.idEstudio FROM Estudios
WHERE idEstudio = '1';

DELETE FROM Usuarios 
WHERE idUsuario = '1';

UPDATE Usuarios 
SET email = 'admin@admin.com'
WHERE idUsuario = '1';


