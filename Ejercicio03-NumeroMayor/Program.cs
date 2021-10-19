using System;

namespace Ejercicio03_NumeroMayor
{
    /*
     * Ejercicio que nos devuelve el mayor
     * etre varios números
     */
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, valor3, mayor;
            // Pregunto al usuario por los valores
            Console.WriteLine("Introduce el primer número:");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número:");
            valor3 = int.Parse(Console.ReadLine());

            // Compruebo cual es el mayor
            /*
            if (valor1 > valor2 && valor1 > valor3)
            {
                mayor = valor1;
            } else if ( valor2 > valor1 && valor2 > valor3)
            {
                mayor = valor2;
            } else
            {
                mayor = valor3;
            }
            */

            mayor = valor1;

            if (valor2 > mayor)
            {
                mayor = valor2;
            }
            if (valor3 > mayor)
            {
                mayor = valor3;
            }
            Console.WriteLine("El número mayor es " + mayor);
        }
    }
}
