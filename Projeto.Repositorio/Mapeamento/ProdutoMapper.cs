using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using Projeto.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Repositorio.Mapeamento
{
    public class ProdutoMapper
    {
        public static void Map()
        {
            if (!BsonClassMap.IsClassMapRegistered(typeof(Produto)))
            {
                BsonClassMap.RegisterClassMap<Produto>(cm =>
                {
                    cm.SetIgnoreExtraElements(true);
                    cm.MapIdMember(c => c.Id).SetElementName("_id").SetSerializer(new StringSerializer(BsonType.ObjectId));
                    cm.MapMember(c => c.Nome).SetElementName("nome");
                    cm.MapMember(c => c.Quantidade).SetElementName("quantidade");
                });
            }
        }
    }
}