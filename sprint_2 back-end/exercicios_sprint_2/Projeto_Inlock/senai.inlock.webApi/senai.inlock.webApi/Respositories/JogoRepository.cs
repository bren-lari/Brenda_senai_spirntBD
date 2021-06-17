using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Respositories
{
    public class JogoRepository : IJogoRespository
    {
        private string stringConexao = "Data Source=DESKTOP-7K8B2IC\\SQLEXPRESS; initial catalog=inlock_games_tarde; user Id=sa; pwd=sa132";
        
        // método atualizar
        public void Atulizar(int id, JogoDomain atualizarJogo)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryUpdate = "UPDATE Jogo" +
                                     "SET nomeJogo = @nomeJogo, descricaoJogo = @descricaoJogo, datDeLancamento = @dataDeLancamento, valor = @valor" +
                                     "WHERE idJogos = @ID";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryUpdate, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", atualizarJogo.idJogos);
                    cmd.Parameters.AddWithValue("@nomeJogo", atualizarJogo.nomeJogo);
                    cmd.Parameters.AddWithValue("@descricaoJogo", atualizarJogo.descricaoJogo);
                    cmd.Parameters.AddWithValue("@dataDeLancamento", atualizarJogo.dataDeLancamento);
                    cmd.Parameters.AddWithValue("@valor", atualizarJogo.valor);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // método buscarPorId
        public JogoDomain BuscarPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string querySelectById = "SELECT idJogos, nomeJogo, descricaoJogo, dataDeLancamento, valor" +
                                        " WHERE idJogos = @ID";

                connection.Open();

                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    sdr = cmd.ExecuteReader();

                    if (sdr.Read())
                    {
                        JogoDomain jogo = new JogoDomain()
                        {
                            idJogos = Convert.ToInt32(sdr["idJogos"]),
                            nomeJogo = Convert.ToString(sdr["nomeJogo"]),
                            descricaoJogo = Convert.ToString(sdr["descriçãoJogo"]),
                            dataDeLancamento = Convert.ToDateTime(sdr["dataDeLancamento"]),
                            valor = Convert.ToDecimal(sdr["valor"])
                        };

                        return jogo;
                    }

                    return null;
                }
            }
        }

        // método cadastrar
        public void Cadastrar(JogoDomain cadastrarJogo)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Jogo (nomeJogo, descricaoJogo, dataDeLancamento, valor) VALUES (@Nome, @Descrição, @dataDeLancamento, @Valor)";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, connection))
                {
                    cmd.Parameters.AddWithValue("@nomeJogo", cadastrarJogo.nomeJogo),
                    cmd.Parameters.AddWithValue("@descricaoJogo", cadastrarJogo.descricaoJogo),
                    cmd.Parameters.AddWithValue("@dataDeLancamento", cadastrarJogo.dataDeLancamento),
                    cmd.Parameters.AddWithValue("@Valor", cadastrarJogo.valor);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // método deletar
        public void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Jogos WHERE idJogos = (@ID)";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(queryDelete, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    cmd.ExecuteNonQuery();
                }
            }
 
        }

        // método listar
        public List<JogoDomain> Listar()
        {
            List<JogoDomain> jogo = new List<JogoDomain>();
                
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT Jogos.nomeJogo, Jogos.descricaoJogo, Jogos.dataDelancamento, Jogos.valor FROM Jogos";

                SqlDataReader sdr;

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(querySelectAll, connection))
                {
                    sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        JogoDomain jogos = new JogoDomain()
                        {
                            idJogos = Convert.ToInt32(sdr[0]),
                            nomeJogo = Convert.ToString(sdr[1]),
                            descricaoJogo = Convert.ToString(sdr[2]),
                            dataDeLancamento = Convert.ToDateTime(sdr[3]),
                            valor = Convert.ToDecimal(sdr[4])
                        };

                        jogo.Add(jogos);
                    }
                    return jogo;
                }
            };

        }
    }
}

       