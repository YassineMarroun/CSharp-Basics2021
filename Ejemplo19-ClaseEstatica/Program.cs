using System;

namespace Ejemplo19_ClaseEstatica
{
    /*
     * Ejemplo de clase estática
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, elige el sentido de la conversión");
            Console.WriteLine("1. De Celsius a Fahrenheit.");
            Console.WriteLine("2. De Fahrenheit a Celsius.");

            int seleccion = int.Parse(Console.ReadLine());
            double F, C;

            switch (seleccion)
            {
                case 1:
                    Console.WriteLine("Introduce la temperatura en ºC:");
                    C = double.Parse(Console.ReadLine());
                    F = ConvertidorTemperatura.CelsiusAFahrenheit(C);
                    Console.WriteLine("Temperatura en ºF: {0:F2}", F);
                    break;
                case 2:
                    Console.WriteLine("Introduce la temperatura en ºF:");
                    F = double.Parse(Console.ReadLine());
                    C = ConvertidorTemperatura.FahrenheitACelsius(F);
                    Console.WriteLine("Temperatura en ºC: {0:F2}", C);
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }
        }
    }
}
