using senai_filmes_webAPI.Domains;
using senai_filmes_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Repositories
{
    /// <summary>
    /// classe responsável pelos repositorios dos generos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// aqui estamos definindo uma variavel para o banco de dados se conectar com o back-end
        /// parametro data source: nome do servidor
        /// initial catalog: nome do banco de dados
        /// user: usuario
        /// pwd: senha do usuario
        /// o user e pwd faz a autenticacao com o sql passando o logon e a senha
        /// </summary>
        private string stringConexao = "Data Source=DESKTOP-7K8B2IC\\SQLEXPRESS; initial catalog=Filmes; user Id=sa; pwd=sa132";


        public void AtualizarIdCorpo(GeneroDomain atualizarGenero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, GeneroDomain atualizargenero)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// cadastra um novo genêro
        /// </summary>
        /// <param name="cadastrarGenero">objeto de um novo genero com as informações que serão cadastradas</param>
        public void Cadastrar(GeneroDomain cadastrarGenero)
        {

            // faz uma conexão "cnx" passando a string conexão 
            using (SqlConnection cnx = new SqlConnection(stringConexao))
            {
                            // o que nós vamos cadastrar e como esse cadastro é feito no banco de dados 
                            // no caso como vamos inserir/cadastrar algo na tablea, a  query que será executada que é INSERT
                            // isso que vai ser enviado para o banco de dados: INSERT INTO Generos(Nome)
                            // VALUES ('Ficção cientifíca')
                            //string queryInsert = "INSERT INTO Generos(Nome) VALUES ('" + cadastrarGenero.nome + " ')";
                            // não usar aspas ou alguns caracteres na hora de cadastrar algo pois pode gerar o erro Joana D'Arc
                            // estaríamos permitindo tb o SQL Injection

                // o que nós vamos cadastrar e como esse cadastro é feito no banco de dados 
                // no caso como vamos inserir/cadastrar algo na tablea, a  query que será executada que é INSERT
                // isso que vai ser enviado para o banco de dados: INSERT INTO Generos(Nome)
                // para não acontecer o SLQ Injection, passamos o parâmetro "@Nome" 
                // esse parâmetro só pode ser definido com um @
                string queryInsert = "INSERT INTO Generos(Nome) VALUES (@Nome)";


                // comando utilizado para fazer com o que de fato o INSERT funcione ou seja executado passando o queryInsert e o cnx como qual banco que vamos 
                // utilizar
                using (SqlCommand ins = new SqlCommand(queryInsert, cnx))
                {

                    // estamos adicionando um parâmetro com um valor 
                    ins.Parameters.AddWithValue("@Nome", cadastrarGenero.nome);
                    // permite a conxeção com o bd
                    cnx.Open();

                    // o ExecuteNonQuey executa a query junto com cnx(qual bd vamos usar)
                    ins.ExecuteNonQuery();
                }

            }
        }

        /// <summary>
        /// método criado para poder deletar um genêro atráves do id
        /// </summary>
        /// <param name="id">id do genêro que será deletado</param>
        public void Deletar(int id)
        {
            // fazer a conexão entre o bd com a slqconnection
            using (SqlConnection dlt = new SqlConnection(stringConexao))
            {

                // declara a queryDelete que passa o parâmetro @ID 
                string queryDelete = "DELETE FROM Generos WHERE idGenero = (@ID)";


                // declarando o comando cmd passando a queryDelete e a conexão: dlt
                using (SqlCommand cmd = new SqlCommand(queryDelete, dlt))
                {

                    // parâmetros adicionado passando a query @id e o id 
                    cmd.Parameters.AddWithValue("@ID", id);

                    // estamos abrindo a conexão com o bd
                    dlt.Open();

                    // comando pronto para ser executado
                    cmd.ExecuteNonQuery();


                }
            }

        }

        public GeneroDomain EncontrarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<GeneroDomain> ListarTodos()
        {
            // lista criada para armazenar os dados de generos
            List<GeneroDomain> listaGeneros = new List<GeneroDomain>();

            // estamos chamando o using passando a variavel "stringConexao" para o 
            // utilizar da lista de generos.
            // assim que trouxermos a lista, vamos sair da conexao e para de rodar ela
            using (SqlConnection cnx = new SqlConnection(stringConexao))
            {

                //declara a instrucao para selecionar o id e nome da tabela generos a ser executada
               // no caso como vamos listar/selecionar algo na tablea, a string query é SelectAll
                string querySelectAll = "SELECT idGenero, Nome FROM Generos";

                // essa linha abre a conexao com o bd
                cnx.Open();

                //declara o sqldatareader sdr para poder percorrer a tabela do bd Generos
                // ele lê o nosso c#
                // armazena e devolve no JSON ou no POSTMAN
                SqlDataReader sdr;

                //declara o sqlcommand cmd passando a queryselectall e cnx para a conexao ser executada
                using (SqlCommand cmd = new SqlCommand(querySelectAll, cnx))
                {
                    // com o executeReader eu executo o comando "queyselectall" e alem disso estamos armazenando
                    // esses valores definindo o sdr antes.
                   // ou seja, alem de executarmos o comando, estamos armazenando ele
                   sdr = cmd.ExecuteReader();

                    // enquanto houver linhas/registros para serem lidos, o laço/while se repete
                    while (sdr.Read())
                    {
                        //instancia um objeto genero do tipo GeneroDomain
                        GeneroDomain genero = new GeneroDomain()
                        {
                            // atribui a propriedade do idgenero da primeira coluna
                            idGenero = Convert.ToInt32(sdr[0]),

                            //atribui a propriedade do nome da segunda coluna
                            nome = sdr[1].ToString()
                        };
                        
                        // adiciona o objeto de lista criado
                        listaGeneros.Add(genero);
                    }
                }
            }

            // retorna a lista de generos
            return listaGeneros;
        }
    }
}
