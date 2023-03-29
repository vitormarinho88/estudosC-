﻿using System;
using System.Collections.Generic;



namespace PROJETOCSHARP
{


    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;


        }
    }


    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachoro {nome} inicializando");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $" {Nome} tem {Altura} cm de altura!";
        }


    }



    class ConstrutorThis
    {


        public static void Executar()
        {
            var spike = new Cachorro("spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max.ToString());
        }





    }

}  