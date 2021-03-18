USE Pessoas;

SELECT * FROM Pessoa;
-- inner join
SELECT * FROM Telefone;
SELECT * FROM Telefone
INNER JOIN Pessoa
ON Telefone.idPessoa = Pessoa.idPessoa;


SELECT * FROM Email;
SELECT Email.Endereco, Email.Senha, Pessoa.Nome FROM Email
LEFT JOIN Pessoa
ON Email.idPessoa = Pessoa.idPessoa;

SELECT * FROM CNH;
SELECT CNH.Numero, Pessoa.Nome FROM CNH
INNER JOIN Pessoa
ON CNH.idPessoa = Pessoa.idPessoa;