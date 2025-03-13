using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp10
{
    internal class Produto
    {
        public double Preco { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public static List<Produto> Lista
        {
            get
            {
                List<Produto> lista = new List <Produto>();
                lista.Add(new Produto() { Nome = "Adaga", Preco = 280, Categoria = "Acessorios" });
                lista.Add(new Produto() { Nome = "Calça", Preco = 400, Categoria = "Acessorios" });
                lista.Add(new Produto() { Nome = "Capacete", Preco = 270, Categoria = "Acessorios" });
                lista.Add(new Produto() { Nome = "Tridente", Preco = 260, Categoria = "Acessorios" });
                lista.Add(new Produto() { Nome = "Lança", Preco = 200, Categoria = "Acessorios" });
                lista.Add(new Produto() { Nome = "Botas", Preco = 400, Categoria = "Acessorios" });

                return lista;
            }
        }
    }
}
