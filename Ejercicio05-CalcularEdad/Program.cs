using System;

namespace Ejercicio05_CalcularEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Today;
            // Pregunto al usuario por su fecha de nacimiento
            Console.WriteLine("Introduce el año que naciste:");
            int anno = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el número de mes que naciste:");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Introuce el número del día del mes en que naciste:");
            int dia = int.Parse(Console.ReadLine());

            int edad = 0;
            edad = hoy.Year - anno;
            if (mes > hoy.Month)
            {
                edad--;
            }
            if (mes == hoy.Month && dia > hoy.Day)
            {
                edad--;
            }
            Console.WriteLine($"Tienes {edad} años");

        }
    }
}
