using Projeto.Dominio.Interfaces.Repositorios;
using Projeto.Repositorio;
using Projeto.Repositorio.Interfaces;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.IoC
{
    public static class BootStrapper
    {
        public static void Register(Container container)
        {
            #region Repositorios

            container.Register<IProdutoRepositorio, ProdutoRepositorio>(Lifestyle.Scoped);
            container.Register<IMongoContexto, MongoContexto>(Lifestyle.Scoped);

            #endregion Repositorios
        }
    }
}