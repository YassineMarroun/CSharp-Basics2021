using System;

namespace Ejercicio04_NumeroMayorArray
{
    /*
     * Programa que nos devuelve el 
     * valor más alto de un array de números
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos números tiene el array?");
            int tamanno = int.Parse(Console.ReadLine());

            int[] numeros = new int[tamanno];
            // Utilizo una instrucción for para rellenar el array
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Introduce el valor del número {i+1}º número:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int mayor = 0;
            foreach (int numero in numeros)
            {
                if (numero > mayor)
                {
                    mayor = numero;
                }
            }
            Console.WriteLine("El valor más alto es " + mayor);
        }
    }
}
