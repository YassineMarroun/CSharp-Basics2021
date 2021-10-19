using System;

namespace Ejercicio02_NumeroDivisible
{
    /*
     * Programa que nos dice si un número
     * es divisible por otro
     */
    class Program
    {
        static void Main(string[] args)
        {
            int operando1, operando2;
            Console.WriteLine("Programa de los números divisibles");
            // Le pedimos el valor de los operandos al usuario
            Console.WriteLine("Introduce el valor del primer número: ");
            operando1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el valor del segundo número: ");
            operando2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Es divisible el primer número por el segundo? " + ((operando1 % operando2) == 0));
        }
    }
}
