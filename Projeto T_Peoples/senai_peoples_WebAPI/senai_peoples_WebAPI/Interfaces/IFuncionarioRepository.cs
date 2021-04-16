using senai_peoples_WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_peoples_WebAPI.Interfaces
{

    // interface responsável pelo funcionario
    public interface IFuncionarioRepository
    {
        // criamos um método de lista para listar todos os funcionários
        // da agência Peoples
        List<FuncionarioDomain> ListarTodos();

        // criamos um método buscar por ID para podermos buscar informações
        // pelo ID
        FuncionarioDomain BuscarPorId(int idFuncionario);


        // método criado para cadastrar um novo funcionário
        // não há retornos
        void Cadastrar(FuncionarioDomain novoFuncionario);

        // método criado para atualizar um funcionários e suas informações pelo id
        // não há retornos
        void Atualizar(int id,FuncionarioDomain novoFuncionario);


        // método criado para deletar algum funcionário pelo id
        void Deletar(int id);



    }
}
