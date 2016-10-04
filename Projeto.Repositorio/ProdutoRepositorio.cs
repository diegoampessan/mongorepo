using Projeto.Dominio.Entidades;
using Projeto.Dominio.Interfaces.Repositorios;
using Projeto.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio
{
    public class ProdutoRepositorio : MongoRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(IMongoContexto contexto)
            : base(contexto, "produto")
        {
        }

        public async Task InserirAsync(Produto produto)
        {
            await Collection.InsertOneAsync(produto);
        }
    }
}