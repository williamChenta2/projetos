using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new LanchoneteEntities();

            //var categoria = new categoria()
            //{
            //    nome = "Sucos"
            //};

            //var produto = new produto()
            //{
            //    categoria = categoria,
            //    nome = "suco de tomate",
            //    preco = 7
            //};

            //db.categoria.Add(categoria);
            //db.produto.Add(produto);

            //db.SaveChanges();

            //Console.WriteLine("categoria cadastrada!");

            buscarProdutos(db);
            Console.ReadKey();
        }

        private static void buscarProdutos(LanchoneteEntities db)
        {
            decimal total = 0;

            var categorias = db.categoria.Select(c => c.produto);

            foreach (var c in categorias)
            {
                Console.WriteLine(c.produto.Sum(p => p.preco));
            }
        }
    }
}
