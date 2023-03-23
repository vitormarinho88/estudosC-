﻿using System;
using System.Collections;
using System.Text;

class ColeçoesStack
{
    public static void Executar ()   {
        var pilha = new Stack();

        pilha.Push(3);
        pilha.Push("a");
        pilha.Push(true);
        pilha.Push(3.14f);

        foreach (var item in pilha)
        {

            Console.WriteLine($"{item} ");

        }

        Console.WriteLine($"\nPop: {pilha.Pop()}");  
        
        foreach (var item in pilha)
        {
            Console.WriteLine($"{item} ");

        }

        Console.WriteLine($"\nPeek: {pilha.Peek()}");
        Console.WriteLine(pilha.Count);
    }



            //Push Adicionar
            //Pop Remover 
}
