using System;

namespace Ejemplo04_OperadoresAritmeticos
{

    /*
     * En ese ejemplo pediremos dos valores numéricos
     * a los cuales les aplicaremos las operaciones aritméticas
     * y mostramos los resultados
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

            // Obtener y mostrar los resultados
            Console.WriteLine("El resultado de la suma es: " + (operando1 + operando2));
            Console.WriteLine("El resultado de la resta es: " + (operando1 - operando2));   
            Console.WriteLine("El resultado de la multiplicación es: " + (operando1 * operando2));
            Console.WriteLine("El resultado de la división es: " + (operando1 / operando2));
            Console.WriteLine("El resto de la división es: " + (operando1 % operando2));
        }
    }
}
