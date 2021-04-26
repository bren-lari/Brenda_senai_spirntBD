USE Senai_SPMEDI_Tarde;

SELECT Usuario.Nome, Usuario.Email, Usuario.idUsuario FROM Usuario


SELECT tipoUsuario.idTipoUsuario, tipoUsuario.tituloTipoUsuario FROM tipoUsuario;


SELECT Medico.Nome, Medico.Email, Medico.EspecialidadeDeterminada FROM Medico;

SELECT * FROM Clinica;

SELECT COnsulta.DataConsulta, Consulta.Situação FROM Consulta
LEFT JOIN Usuario
ON Consulta.idUsuario = Usuario.idUsuario;

SELECT Consulta.DataConsulta, Consulta.Situação FROM Consulta;

SELECT * FROM Especialidade;

SELECT * FROM Paciente;




