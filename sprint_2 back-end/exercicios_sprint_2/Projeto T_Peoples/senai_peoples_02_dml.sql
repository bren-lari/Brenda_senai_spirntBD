USE T_Peoples;
GO

INSERT INTO Funcionarios(nome, sobrenome)
VALUES					('Catarina', 'Strada'),
						('Tadeu', 'Vitelli');
GO

DELETE FROM Funcionarios
WHERE idFuncionarios = '1';