USE Locadora;

INSERT INTO Empresa(Endereco, DonoDaEmpresa)
VALUES		('R.Lima de Lima, 90, 90', 'Michael Ronald'),
			('R.Lima de Lima, 90', 'Henry Longford');

INSERT INTO Veiculo(idEmpresa, Placa, AnoDeLancamento)
VALUES			(1, 'CD142', '22/02/2007'),
				(2, 'BC568', '13/09/2011');

INSERT INTO Cliente(idEmpresa, Nome, ModeloDocarro)
VALUES		(1, 'Robert Lauren', 'Chevrolet TRAX');
