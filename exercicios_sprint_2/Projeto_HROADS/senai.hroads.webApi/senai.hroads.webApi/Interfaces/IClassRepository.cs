]using senai.hroads.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi_.Interfaces
{
    interface IClassRepository
    {

        /// <summary>
        /// método de listagem
        /// </summary>
        /// <returns>uma lista de classes</returns>
        List<Class> Listar();


        /// <summary>
        /// método buscar por id
        /// </summary>
        /// <param name="id">id da classe que vai ser buscada</param>
        /// <returns>uma classe que foi buscada pelo id</returns>
        Class BuscarPorId(int id);


        /// <summary>
        /// cadastra uma nova classe
        /// </summary>
        /// <param name="cadastrarClasse">objeto cadastrarClasse que será cadastrada</param>
        void Cadastrar(Class cadastrarClasse);


        /// <summary>
        /// atualiza uma lista com novas classes
        /// </summary>
        /// <param name="id"></param>
        /// <param name="classeAtualizada">objeto classeAtualizada que será atualizada</param>
        void Atualizar(int id, Class classeAtualizada);


        /// <summary>
        /// deleta uma classe
        /// </summary>
        /// <param name="id">id que será usado para deletar uma classe</param>
        void Deletar(int id);
    }
}
