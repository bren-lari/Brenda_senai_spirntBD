USE Senai_Hroads_Tarde;

SELECT * FROM Classes;
SELECT Classes.NomeClasse FROM Classes;

SELECT * FROM Personagens;


SELECT * FROM Habilidades;

SELECT COUNT(*) Habilidades
FROM Habilidades
GO

SELECT Habilidades.idHabilidade FROM Habilidades;

SELECT TiposHabilidades.Tipo FROM TiposHabilidades;

SELECT Habilidades.NomeHabilidade, TiposHabilidades.Tipo FROM Habilidades
LEFT JOIN TiposHabilidades
ON Habilidades.idTiposHabilidades = TiposHabilidades.idTiposHabilidades;


SELECT Personagens.Nome, Classes.NomeClasse FROM Personagens
LEFT JOIN Classes
ON Personagens.idClasse = Classes.idClasse;


SELECT Personagens.Nome, Classes.NomeClasse FROM Personagens
RIGHT JOIN Classes
ON Personagens.idClasse = Classes.idClasse;

SELECT Habilidades.NomeHabilidade, Classes.NomeClasse FROM Habilidades
LEFT JOIN Classes
ON Habilidades.idHabilidade = Classes.idClasse;


SELECT Habilidades.NomeHabilidade, Classes.NomeClasse FROM Habilidades
RIGHT JOIN Classes
ON Habilidades.idHabilidade = Classes.idClasse;

