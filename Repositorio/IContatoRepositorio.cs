using ControleContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleContatos.Repositorio;

    public interface IContatoRepositorio 
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel ListarPorId(int id);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }



