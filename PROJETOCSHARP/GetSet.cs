using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

public class Moto
{

    private string Marca;
    private string Modelo;
    private uint Cilindrada;

    public Moto(string marca, string modelo, uint cilindrada)
    {

        //Marca = marca;
        //Modelo = modelo;
        //Cilindrada = cilindrada;

        SetMarca(marca);
        SetModelo(modelo);
        SetCilindrada(cilindrada);

    }

    public Moto()
    {



    }

    public string GetMarca()
    {

        return Marca;

    }

    public void SetMarca(string marca)
    {
        Marca = marca;

    }

    public string GetModelo()
    {

        return Modelo;

    }

    public void SetModelo(String modelo)
    {

        Modelo = modelo;

    }


    public uint GetCilindrada()
    {

        return Cilindrada;

    }

    public void SetCilindrada(uint cilindrada)
    {

        Cilindrada = cilindrada;

    }
}

    class GetSet
    {
        public static void Executar() { 
        
                var moto1 = new Moto("kawasaki", "Ninja ZX10R", 1000);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Kawasaki");
            moto2.SetModelo("ZX10R");
            moto2.SetCilindrada(1000);

            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
        
        }





    }



