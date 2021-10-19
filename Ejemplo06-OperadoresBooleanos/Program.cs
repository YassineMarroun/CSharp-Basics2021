using System;

namespace Ejemplo06_OperadoresBooleanos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Resultado de las operaciones cuando los dos son falsos
            Console.WriteLine("Cuando los dos valores son falsos:");
            Console.WriteLine("Operación AND (&&): " + (false && false));
            Console.WriteLine("Operación OR (||): " + (false || false));
            Console.WriteLine("Operación OR exclusivo (^): " + (false ^ false));

            // Resultado de las operaciones cuando el primer valor es falso y el segundo verdadero
            Console.WriteLine("Cuando el primer valor es falso y el segundo verdadero:");
            Console.WriteLine("Operación AND (&&): " + (false && true));
            Console.WriteLine("Operación OR (||): " + (false || true));
            Console.WriteLine("Operación OR exclusivo (^): " + (false ^ true));

            // Resultado de las operaciones cuando el primer valor es verdadero y el segundo falso
            Console.WriteLine("Cuando el primer valor es verdadero y el segundo falso:");
            Console.WriteLine("Operación AND (&&): " + (true && false));
            Console.WriteLine("Operación OR (||): " + (true || false));
            Console.WriteLine("Operación OR exclusivo (^): " + (true ^ false));

            // Resultado de las operaciones cuando los dos son verdaderos
            Console.WriteLine("Cuando los dos valores son falsos:");
            Console.WriteLine("Operación AND (&&): " + (true && true));
            Console.WriteLine("Operación OR (||): " + (true || true));
            Console.WriteLine("Operación OR exclusivo (^): " + (true ^ true));
        }
    }
}
