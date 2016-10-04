using Projeto.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.Interfaces.Repositorios
{
    public interface IProdutoRepositorio
    {
        Task InserirAsync(Produto produto);
    }
}