using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Respositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private string stringConexao = "Data Source=DESKTOP-7K8B2IC\\SQLEXPRESS; initial catalog=inlock_games_tarde; user Id=sa; pwd=sa132";

        // método de listar
        public List<UsuarioDomain> Listar()
        {
            List<UsuarioDomain> usuario = new List<UsuarioDomain>();

            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT Usuarios.email, Usuarios.senha FROM Usuarios WHERE email LIKE '%.com%'; ";

                connection.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, connection))
                {
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        UsuarioDomain usuarios = new UsuarioDomain()
                        {
                            idUsuario = Convert.ToInt32(sdr[0]),
                            email = Convert.ToString(sdr[1]),
                            senha = Convert.ToString(sdr[2])
                        };

                        usuario.Add(usuarios);
                    }
                    return usuario;

                }
            }
        }

        // método de atualizar
        public void Atualizar(int id, UsuarioDomain atualizarUsuario)
        {

            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE Usuarios " +
                                     "SET Email = @Email, Senha = @Senha" +
                                     "WHERE idUsuario = @ID";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryUpdate, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", atualizarUsuario.idUsuario);
                    cmd.Parameters.AddWithValue("@Email", atualizarUsuario.email);
                    cmd.Parameters.AddWithValue("@Senha", atualizarUsuario.senha);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // método buscar por ID
        public UsuarioDomain BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string querySelectById = "SELECT idUsuario, Email, Senha" +
                                        " WHERE idUsuario = @ID";
                connection.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain()
                        {
                            idUsuario = Convert.ToInt32(sdr["idUsuario"]),
                            email = Convert.ToString(sdr["email"]),
                            senha = Convert.ToString(sdr["senha"])

                        };

                        return usuario;
                    }
                    return null;

                }
            }
        }

        // método para cadastrar
        public void Cadastrar(UsuarioDomain cadastrarUsuario)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Usuarios(email, senha) VALUES(@Email, @Senha)";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", cadastrarUsuario.email);
                    cmd.Parameters.AddWithValue("@Senha", cadastrarUsuario.senha);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        
        // método de deletar
        public void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Usuarios WHERE idUsuario = (@ID)";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}

