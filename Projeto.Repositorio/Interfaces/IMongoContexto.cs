using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio.Interfaces
{
    public interface IMongoContexto
    {
        IMongoClient Client { get; }
        IMongoDatabase DataBase { get; }
    }
}