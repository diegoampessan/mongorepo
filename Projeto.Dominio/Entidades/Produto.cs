using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Dominio.Entidades
{
    public class Produto
    {
        public string Id { get; private set; }
        public string Nome { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }

        public void AtribuirNome(string nome)
        {
            Nome = nome;
        }

        public void AtualizarQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }
    }
}