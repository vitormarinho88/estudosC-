using System;


namespace PROJETOCSHAP.ClassesEMetodos
{



    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(1998, 01, 19);
        }

        public string GetDataNascimento()
        {

            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);

        }

    }


    class ReadOnly
    {
        static public void Executar()
        {

            var novoCliente = new Cliente("Vitor Marinho", new DateTime(1998, 1, 19));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());

            // novoCliente.Nascimento = new DateTime (2020, 10, 10);
        }



    }




}










