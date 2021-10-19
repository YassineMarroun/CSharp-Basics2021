using System;

namespace Ejemplo05_OperadoresComparacion
{
    /*
     * En este ejemplo pediremos dos valores numéricos
     * a los cuales le aplicaremos las operaciones de comparación
     * y mostraremo los resultados
     */
    class Program
    {
        static void Main(string[] args)
        {
            int operando1, operando2;
            // Le pedimos el valor de los operandos al usuario
            Console.WriteLine("Introduce el valor del primer operando: ");
            operando1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor del segundo operando: ");
            operando2 = int.Parse(Console.ReadLine());

            // Obtenemos y mostramos los resultados
            Console.WriteLine("¿Primer operando igual (==) que segundo operando? " + (operando1 == operando2));
            Console.WriteLine("¿Primer operando distinto (!=) que segundo operando? " + (operando1 != operando2));
            Console.WriteLine("¿Primer operando mayor (>) que segundo operando? " + (operando1 > operando2));
            Console.WriteLine("¿Primer operando mayor o igual (>=) que segundo operando? " + (operando1 >= operando2));
            Console.WriteLine("¿Primer operando menor (<) que segundo operando? " + (operando1 < operando2));
            Console.WriteLine("¿Primer operando menor o igual (<=) que segundo operando? " + (operando1 <= operando2));
        }
    }
}
