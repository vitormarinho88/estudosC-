using System;
using System.Collections.Generic;
using System.Text;


namespace PROJETOCSHAP.ClassesEMetodos {

    public enum Genero { Ação, Aventura, Terror, Animação, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum {

        public static void Executar()
        {
            int id = (int)Genero.Animação;
            Console.WriteLine(id);

            var filmeParaFamilia=new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é `{1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        
        
        }
        

          
    
    
    
    
    
    
    
    
    
    
    }







}





