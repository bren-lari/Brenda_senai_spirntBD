using senai_filmes_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Interfaces
{
    /// <summary>
    /// interface responsável pelo repository genero
    /// </summary>
    public interface IGeneroRepository
    {
        // tiporetorno, nomemetodo(tipoparamentro, nomeparametro)

        /// <summary>
        /// esse método vai listar todos os generos da tabela
        /// </summary>
        /// <returns> Litsa de generos</returns>
        List<GeneroDomain> ListarTodos();


        /// <summary>
        /// encontra um genêro atráves do seu id
        /// </summary>
        /// <param name="id"> id do genero que será buscado</param>
        /// <returns> objeto que foi buscado, que no caso foi atráves do id </returns>
        GeneroDomain EncontrarPorId(int id);


        /// <summary>
        /// método para cadastrar um genero
        /// </summary>
        /// <param name="cadastrarGenero"> objeto cadastrarGenero com as informações cadastradas</param>
        void Cadastrar(GeneroDomain cadastrarGenero);


        /// <summary>
        /// atualiza o genero que ja existe, passando o id pelo corpo da request
        /// </summary>
        /// <param name="atualizarGenero"> objeto genero com as novas informações</param>
        void AtualizarIdCorpo(GeneroDomain atualizarGenero);


        /// <summary>
        /// atualiza um genero que ja existe, passando o id pela url da request
        /// </summary>
        /// <param name="id">id do genero que sera autualizado</param>
        /// <param name="atualizargenero"> objeto genero com novas informações</param>
        void AtualizarIdUrl(int id, GeneroDomain atualizargenero);


        /// <summary>
        /// deleta um genero atráves do seu id
        /// </summary>
        /// <param name="id"> id do genero que vai ser deletado atraves desse metodo</param>
        void Deletar(int id);
    }
}
