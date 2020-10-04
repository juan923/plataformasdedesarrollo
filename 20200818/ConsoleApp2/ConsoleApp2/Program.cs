using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("ingrese un numero: ");
            int dado = 1;
            string valor = Console.ReadLine();
            dado = int.Parse(valor);
            String mensaje;
            if (dado == 1)
            {
                mensaje = ("Ganaste Carro");
            }
            else if (dado == 2)
            {
                mensaje = "vuelve a intentar");
            } else
            {
                mensaje = ("perdiste");
            }
            Console.Write($"tu dado fue {dado} y ganaste {mensaje}");*/

            int dato = 0;
            int total = 0;
            for (int posicion =0; posicion < 10; posicion++)
            {
                string valor = Console.ReadLine();
                dato = int.Parse(valor);
                total = total + dato;
                if (total == 50)
                {
                    break;
                }
            }
            Console.WriteLine(total);
        }
    }
}
