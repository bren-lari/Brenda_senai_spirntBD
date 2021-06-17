using senai_peoples_WebAPI.Domains;
using senai_peoples_WebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_peoples_WebAPI.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        /// <summary>
        /// váriavel para o banco de dados e suas tabelas se conectar com a nossa API 
        /// </summary>
        private string stringConexao = "Data Source=DESKTOP-7K8B2IC\\SQLEXPRESS; initial catalog=T_Peoples; user Id=sa; pwd=sa132";

        public void Atualizar(int id, FuncionarioDomain novoFuncionario)
        {
            throw new NotImplementedException();
        }

        public FuncionarioDomain BuscarPorId(int idFuncionario)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryAtual
            }
        }

        // cadastrar um novo funcionário passando o nome e sobrenome obrigatoriamente
        public void Cadastrar(FuncionarioDomain novoFuncionario)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO Funcionarios(nome, sobrenome) VALUES (@Nome, @Sobrenome)";

                using (SqlCommand smd = new SqlCommand(queryInsert, connection))
                {
                    smd.Parameters.AddWithValue("@Nome", novoFuncionario.nome);
                    smd.Parameters.AddWithValue("@Sobrenome", novoFuncionario.sobrenome);

                    connection.Open();

                    smd.ExecuteNonQuery();
                }
            }
        }


        // deletar algum funcionário atráves do ID
        public void Deletar(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM Funcionarios WHERE idFuncionarios = (@ID)";


                using (SqlCommand smd = new SqlCommand(queryDelete, connection))
                {
                    smd.Parameters.AddWithValue("@ID", id);

                    connection.Open();

                    smd.ExecuteNonQuery();
                }
            }
        }


        // listando os funcionários 
        public List<FuncionarioDomain> ListarTodos()
        {
            List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>();

            using (SqlConnection connection = new SqlConnection(stringConexao))
            {

                // atribuimos uma query para selecionar todos os valores da tabela
                string querySelectAll = "SELECT idFuncionarios, nome, sobrenome FROM Funcionarios";
                
                // abrimos a nossa conexão
                connection.Open();

                // usado para percorrer a tabela funcionarios
                // e nos devolve em JSON para usarmos no nosso POSTMAN
                SqlDataReader sdr;


                // declaramos o nosso sqlCommand para o nosso comando ser executado
                // passamos como parâmetro a nossa query e nossa conexçao
                using (SqlCommand smd = new SqlCommand(querySelectAll, connection))
                {
                    // com o executeReader eu executo o comando "queyselectall" e alem disso estamos armazenando
                    // esses valores definindo o sdr antes.
                    // ou seja, alem de executarmos o comando, estamos armazenando ele
                    sdr = smd.ExecuteReader();


                    // criamos o nosso while/laço para enquanto estiver linhas para serem lidas 
                    // esse laço se repete
                    while (sdr.Read())
                    {

                        // instancia um objeto funcionario do FuncionarioDomain
                        // para poder adicionar as informações da tabela no while/laço
                        FuncionarioDomain funcionario = new FuncionarioDomain()
                        {
                            // atribui a propriedade do nome da primeira coluna
                            // com o parâmetro sdr que percorre a tabela
                             idFuncionarios = Convert.ToInt32(sdr[0]),

                            // atribui a propriedade do nome da segunda coluna
                            // com o parâmetro sdr que percorre a tabela
                            nome = Convert.ToString(sdr[1]),

                            // atribui a propriedade do nome da terceira coluna 
                            // com o parâmetro sdr que percorre a tabela
                            sobrenome = Convert.ToString(sdr[2])
                        };

                        // adiciona a tablea funcionario
                        funcionarios.Add(funcionario);
                    }

                        // quando ele adicionar a tabela ele lista listar ela e vai fazer um 
                        // retorno dessa tabela funcionarios
                        return funcionarios;
                }






            }
        }
    }
}
