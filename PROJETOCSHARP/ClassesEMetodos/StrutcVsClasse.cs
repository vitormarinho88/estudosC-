using System;


namespace PROJETOCSHAP.ClassesEMetodos
{

    public struct SPonto
    {
        public int X;
        public int Y;
    }


    public class CPonto
    {
        public int X;
        public int Y;
    }


    class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //Atribuição por valor   
            ponto1.X = 1;

            Console.WriteLine("Ponto 1 x:{0}", ponto1);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto CopiaPonto2 = ponto2; // Atribuição por referencia 
            ponto2.X = 4;


            Console.WriteLine("Ponto 2 x:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", CopiaPonto2.X);
        }



    }





}







