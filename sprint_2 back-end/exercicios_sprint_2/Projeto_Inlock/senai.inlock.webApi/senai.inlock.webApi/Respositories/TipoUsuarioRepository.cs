using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Respositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
    private string stringConexao = "Data Source=DESKTOP-7K8B2IC\\SQLEXPRESS; initial catalog=inlock_games_tarde; user Id=sa; pwd=sa132";
       

        // método atualizar
        public void Atualizar(int id, tipoUsuarioDomain atulizarTipoUsuario)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE tipoUsuarios" +
                                     "SET tituloUsuario = @tituloUsuario" +
                                     "WHERE idTipoUsuario = @ID";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryUpdate, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", atulizarTipoUsuario.idTipoUsaurio);
                    cmd.Parameters.AddWithValue("@tituloUsuario", atulizarTipoUsuario.tituloUsuario);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // método buscarPorId
        public tipoUsuarioDomain BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string querySelectById = "SELECT idTipoUsuario, tituloUsuario" +
                                          "WHERE idTipoUsuario = @ID";

                connection.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        tipoUsuarioDomain tipoUsuario = new tipoUsuarioDomain()
                        {
                            idTipoUsaurio = Convert.ToInt32(sdr["idUsuario"]),
                            tituloUsuario = Convert.ToString(sdr["tituloUsuario"])
                        };

                        return tipoUsuario;
                    }
                    return null;
                }
            }
        }


        // método cadastrar
        public void Cadastrar(tipoUsuarioDomain cadastrarTipoUsuario)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO tipoUsuarios (tituloUsuario) VALUES (@tituloUsuario)";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, connection))
                {
                    cmd.Parameters.AddWithValue("@tituloUsuario", cadastrarTipoUsuario.tituloUsuario);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // método deletar
        public void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM tipoUsuarios.tituloUsuario WHERE idTipoUsuario = @ID";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // método listar
        public List<tipoUsuarioDomain> Listar()
        {
            List<tipoUsuarioDomain> tipoUsuario = new List<tipoUsuarioDomain>();

            using (SqlConnection connection = new SqlConnection(stringConexao) )
            {
                string querySelectAll = "SELECT tipoUsuarios.tituloUsuario FROM tipoUsuario";

                connection.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, connection))
                {
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        tipoUsuarioDomain tipoUsuarios = new tipoUsuarioDomain()
                        {
                            idTipoUsaurio = Convert.ToInt32(sdr[0]),
                            tituloUsuario = Convert.ToString(sdr[1])
                        };

                        tipoUsuario.Add(tipoUsuarios);
                    }

                    return tipoUsuario;
                }
            }

            
        }
    }
}
