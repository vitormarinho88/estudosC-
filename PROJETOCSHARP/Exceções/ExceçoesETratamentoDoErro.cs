﻿using System;
using System.Collections;
using System.Text;


namespace PROJETOCSHAP.Exceções
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;

        }

        public void Sacar(double Valor)
        {
            if (Valor > Saldo)
            {

                throw new ArgumentException("Saldo insuficiente.");
            }

            Saldo -= Valor;
        }



    }


    class PrimeiraExceçao
    {


        public static void Executar()
        {

            var conta = new Conta(1_223.45);


            try
            {
                //int.Parse("abc");

                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {

                Console.WriteLine("Obrigado!");

            }








        }











    }


}
