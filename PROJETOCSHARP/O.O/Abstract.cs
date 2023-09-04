using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETOCSHARP.O.O
{
    public abstract class Celular
    {
        public abstract string Assistencia();

        public string Tocar()
        {
            return "tlim tlim..";
        }

    }

    public class Xiaomi : Celular
    {
        public override string Assistencia()
        {
            return "Óla! meu nome é Vitor!";

        }



    }

    public class Iphone : Celular
    {
        public override string Assistencia()
        {
            return "Olá! Meu nome é vitim!";
        }

    }


    

     class Abstract
     {


        public static void Executar()  {
            var celulares = new List<Celular>()
            {
                new Iphone(),
                new Xiaomi()

            };
          
            
        
            foreach (var celular in celulares)
            {
                Console.WriteLine(celular.Assistencia());

            }
         
        
        
        
        
        
        }















         
     }
        
        
    

    

    






}








