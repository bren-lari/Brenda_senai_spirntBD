USE Senai_Hroads_Tarde;

INSERT INTO Classes(NomeClasse)
VALUES	('Bárbaro')
		,('Cruzado')
		,('Caçadora de Demônios')
		,('Monge')
		,('Necromante')
		,('Feiticeiro')
		,('Arcanista');

INSERT INTO TiposHabilidades (Tipo)
VALUES	('Ataque')
		,('Defesa')
		,('Cura')
		,('Magia');

INSERT INTO Habilidades (idTiposHabilidades,NomeHabilidade)
VALUES	(1, 'Lança Mortal')
		,(2, 'Escudo Supremo')
		,(3, 'Recuperar Vida');

INSERT INTO ClassesHabilidades (idClasse, idHabilidade)
VALUES	(1,1)
		,(1,2)
		,(2,2)
		,(3,1)
		,(4,3)
		,(4,2)
		,(5, NULL)
		,(6,2)
		,(7, NULL);

INSERT INTO Personagens (idClasse, Nome, PVmaximo, ManaMaxima, DataAtt, DataCr)
VALUES	(1, 'DeuBug', 100, 80,'02/03/2021','18/01/2019')
		,(4, 'BitBug', 70, 100,'02/03/2021' ,'17/03/2016' )
		,(7, 'Fer8', 75, 60,'02/03/2021' ,'18/03/2018');
	

UPDATE Personagens
SET Nome = 'Fer7'
WHERE idPersonagem = 3;

UPDATE Classes
SET NomeClasse = 'Necromancer'
WHERE idClasse = 5;
