USE Senai_SPMEDI_Tarde;

INSERT INTO Usuario (Nome, Email, Senha)
VALUES			   ('Rafael', 'rafael@gmail.com', '1234r'),
				   ('Cristina', 'cristina@gmail.com', '1234c'),
				   ('Anderlon', 'anderlon@gmail.com', '1234a');



INSERT INTO tipoUsuario (idUsuario,tituloTipoUsuario)
VALUES					('1', 'Administrador'),
						('2', 'Médico'),
						('3', 'Paciente');


INSERT INTO Medico (Nome, Email, Senha, EspecialidadeDeterminada)
VALUES				('Jerry', 'jerry@gmail.com', 'jerry123', 'Pediatra'),
					('Ursula', 'ursula@gmail.com', 'ursula456', 'Psiquiatra'),
					('Lauren', 'lauren@gmail.com', 'lauren789', 'Cardilogista');

INSERT INTO Clinica (Endereco, HorarioDeFuncionamento, CNPJ)
VALUES				('R.José de Almeida', '8h ás 18h', '0000000-0');
					

INSERT INTO Consulta (idUsuario, DataConsulta, Situação)
VALUES				 ('3', '24-03-2021', 'Consulta Realizada');


INSERT INTO Especialidade (idUsuario, NomeEspecialidade)
VALUES					  ('1', 'Pediatra'),
						  ('2', 'Psiquiatra'),
						  ('3', 'Cardilogista');


INSERT INTO Paciente (idConsulta, Nome)
VALUES				('1','Carlos Eduardo Nogueira'),
					('2', 'Maria Soares'),
					('3', 'Ednéia da Silva de Lurdes');
