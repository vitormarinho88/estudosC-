using System;
using System.Collections.Generic;
using System.Text;


namespace PROJETOCSHAP.Coleções
{
    public class Produto
    {

        public string Nome;
        public double Preço;

        public Produto(string nome, double preço)
        {

            Nome = nome;
            Preço = preço;

        }


        public override bool Equals(object obj)
        {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreço = Preço == outroProduto.Preço;
            return mesmoNome && mesmoPreço;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }








    }

    class ColecsList
    {

        public static void Executar()
        {
            var livro = new Produto("EL SUENO DEL DJ", 98.0);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);


            var combo = new List<Produto> {
            new Produto("camisa", 50.0),
            new Produto("susentrip", 99.0),
            new Produto("ingresso", 150.0)


        };


            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.WriteLine(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preço}");

            }


            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);




        }



























    }





}










