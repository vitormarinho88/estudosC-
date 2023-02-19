using Microsoft.VisualBasic;
using System;

class CalculadoraComum
{

    public int Somar(int a, int b)
    {
        return a + b;

    }

    public int subtrair(int a, int b)
    {
        return a - b;
    }


    public int Multiplicar(int a, int b)
    {
        return a * b;
    }


}


class CalculadoraCadeia
{
    int memoria;
      
    public CalculadoraCadeia somar (int a)
    {
        memoria += a;
        return this;
    }

    public CalculadoraCadeia Multiplicar (int a)
    {
        memoria *= a;
        return this;
    
    }   

    public CalculadoraCadeia Limpar()
    {
        memoria = 0;
        return this;


    }

    public CalculadoraCadeia Imprimir()
    {
        Console.WriteLine(memoria);
        return this;

    }

    public int Resultado()
    {
        return memoria;

    }



}







class MetodosComRetorno
{
    public static void Executar ()
    {
        var calculadoraComum = new CalculadoraComum();
        var resultado = calculadoraComum.Somar(5, 5);

        Console.WriteLine(resultado);
        Console.WriteLine(calculadoraComum.subtrair(2, 7));
        Console.WriteLine(calculadoraComum.Multiplicar(4, 4));

        var calculadoraCadeia = new CalculadoraCadeia();
        calculadoraCadeia.somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

        resultado = calculadoraCadeia.somar(3).Multiplicar(2).Resultado();
        Console.WriteLine(resultado);



    }




}
    
   
   







   