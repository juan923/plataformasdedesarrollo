using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //si se cumple no entra ni una vez
            //int numero = 0;
            //while(numero <10)
            //{
            //    Console.WriteLine(numero);
            //    numero++;
            //}
            //me aseguro que entra por lo menos una vez
            //do
            //{
            //    Console.WriteLine(numero);
            //} while (numero < 10);


            //int intentos = 1;
            //string clave = "";
            //while (clave!="secreto" && intentos<4)
            //{
            //    Console.Write("ingrese la contraseña: ");
            //    clave = Console.ReadLine();
            //    intentos++;
            //}

            int numero = 0;
            int intentos = 0;
            while (numero != 5 && intentos < 3)
            {
                intentos++;
                Console.Write("Adivine el numero: ");
                numero=int.Parse(Console.ReadLine());
                
                Console.WriteLine(numero);

                if (numero == 5)
                {
                    Console.WriteLine("advinaste");
                }else{
                    Console.WriteLine("Siga participando");
                }
            }

        }
    }
}
