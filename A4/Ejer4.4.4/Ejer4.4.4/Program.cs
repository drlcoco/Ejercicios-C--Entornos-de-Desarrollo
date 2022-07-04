using System;

namespace Ejer4._4._4
{
    class Program
    {
        static void Main(string[] args)

        {

            int numero = 1;
            string nombre = "";
            float nota1 = 0;
            float nota2 = 0;
            float promedio = 0;
            float suma = 0;

            System.Console.WriteLine("Cuantos estudiantes quiere calificar");
            numero = int.Parse(Console.ReadLine());

            for (byte i = 0; i < numero; i++)
            {
                Console.Write("NOMBRE: ");
                nombre = Console.ReadLine();

                Console.Write("NOTA 1: ");
                nota1 = int.Parse(Console.ReadLine());

                Console.Write("NOTA 2: ");
                nota2 = int.Parse(Console.ReadLine());


                promedio = (nota1 + nota2) / 2;
                Console.WriteLine("PROMEDIO: " + promedio);

                suma += promedio; 
            }

            Console.WriteLine("SUMA TOTAL ES: " + suma);
            Console.WriteLine("MEDIA ARITMETICA: " + suma / numero);















        }
    }
}
