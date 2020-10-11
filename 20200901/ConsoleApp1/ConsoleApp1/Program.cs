using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Random random = new Random();
            int secreto = random.Next(10);
            int intentos = 0;
            int numero = 0;
            while (intentos <3 && secreto != numero)
            {
                Console.WriteLine("ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                intentos++;

                if (numero == secreto)
                {
                    Console.WriteLine("¡GANASTE!");
                }
                else
                {
                    Console.WriteLine("Intenta de nuevo");
                }
                
            }
            Console.WriteLine("el numero correcto es " + secreto);
        }*/



            /* Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;

            for (int i = 0; i < 3; i++)
            {
                numero = IngreseElNumero("Ingrese el numero: ");
                if (numero == secreto) break;
            }
            if (numero == secreto)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Perdiste(secreto);
            }
        }
        static int IngreseElNumero(string mensaje)
        {
            Console.Write(mensaje);
            return int.Parse(Console.ReadLine());
            
        }

        static void Ganaste()
        {
            Console.WriteLine("Ganaste");
        }
        static void Perdiste(int numero)
        {
            Console.WriteLine("el numero correcto es " + numero);
        }*/

            Console.WriteLine(añobisiesto(IngreseAño("ingrese el año en que nacio: ")));

        }

        static int IngreseAño(string mensaje)
        {
            Console.Write(mensaje);
            int año = int.Parse(Console.ReadLine());
            return año;
        }
        static bool añobisiesto(int año)
        {
            if (año % 4 == 0 && año % 100 != 0)
            {
               return true;
            }
            else
            {
                return false;
            }
        }
    }
}