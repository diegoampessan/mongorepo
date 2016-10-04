using MongoDB.Driver;
using Projeto.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio
{
    public class MongoRepositorio<TEntity> where TEntity : class
    {
        public IMongoCollection<TEntity> Collection;

        public MongoRepositorio(IMongoContexto contexto, string collectionName)
        {
            Collection = contexto.DataBase.GetCollection<TEntity>(collectionName);
        }
    }
}