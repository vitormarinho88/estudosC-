﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{ 

    

    public class AmigoProximo
    {

        public readonly Subcelebridade amiga = new Subcelebridade();

        

        public void MeusAcessos()
        {
            Console.WriteLine("AmigoProximo...");

            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDoOlho);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            // Console.WriteLine(amiga.SegredoFamilia);
            // Console.WriteLine(amiga.UsaMuitoPhotoshop);

        }

        public static void Executar()
        {
            var amigoProximo = new AmigoProximo();
            amigoProximo.MeusAcessos();
        }


           
                

        










    }











}     


