using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Respositories
{
    public class EstudioRepository : IEstudioRepository
    {
        private string stringConexao = "Data Source=DESKTOP-7K8B2IC\\SQLEXPRESS; initial catalog=inlock_games_tarde; user Id=sa; pwd=sa132";

        public void Atualizar(int id, EstudioDomain atualizarEstudio)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryUptade = "UPDATE Estudios" +
                                     "SET nomeEstudio = @nomeEstudio" +
                                      "WHERE idEstudio = @ID";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryUptade, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", atualizarEstudio.idEstudio);
                    cmd.Parameters.AddWithValue("@nomeEstudio", atualizarEstudio.nomeEstudio);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // método buscarPorId
        public EstudioDomain BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string querySelectById = "SELECT idEstudio, nomeEstudio" +
                                          "WHERE  idEstudio = (@ID)";

                connection.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        EstudioDomain estudio = new EstudioDomain()
                        {
                            idEstudio = Convert.ToInt32(sdr["@idEstudio"]),
                            nomeEstudio = Convert.ToString(sdr["@nomeJogo"])
                        };

                        return estudio;
                    }

                    return null;  
                }
            }
        }

        // método cadastrar
        public void Cadastrar(EstudioDomain cadastrarEstudio)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Estudios (nomeJogo) VALUES (@nomeJogo)";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, connection))
                {
                    cmd.Parameters.AddWithValue("@nomeJogo", cadastrarEstudio.nomeEstudio);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // método deletar
        public void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Estudios WHERE idEstudio = (@ID)";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // método listar
        public List<EstudioDomain> Listar()
        {
            List<EstudioDomain> estudio = new List<EstudioDomain>();

            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT Estudios.nomeEstudio FROM Estudios";

                connection.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, connection))
                {
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        EstudioDomain estudios = new EstudioDomain()
                        {
                            idEstudio = Convert.ToInt32(sdr[0]),
                            nomeEstudio = Convert.ToString(sdr[1])
                        };

                        estudio.Add(estudios);
                    }

                    return estudio;
                }
            }
        }
    }
}
