using MongoDB.Driver;
using Projeto.Repositorio.Interfaces;
using Projeto.Repositorio.Mapeamento;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio
{
    public class MongoContexto : IMongoContexto
    {
        private readonly string _connectionString;
        private readonly string _databaseName;
        private IMongoDatabase _database;
        private IMongoClient _client;

        public MongoContexto()
        {
            _databaseName = ConfigurationManager.AppSettings["DATABASE"].ToString();
            _connectionString = ConfigurationManager.AppSettings["CONNSTRING"].ToString();
            Map();
        }

        public IMongoClient Client
        {
            get
            {
                if (_client == null)
                    _client = new MongoClient(_connectionString);

                return _client;
            }
        }

        public IMongoDatabase DataBase
        {
            get
            {
                if (_database == null)
                    _database = Client.GetDatabase(_databaseName);

                return _database;
            }
        }

        private void Map()
        {
            ProdutoMapper.Map();
        }
    }
}