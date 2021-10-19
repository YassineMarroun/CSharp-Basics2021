using System;

namespace Ejemplo11_InstruccionIf
{
    /*
     * Ejemplo de uso de if
     * Verificamos la temperatura del agua
     */
    class Program
    {
        static void Main(string[] args)
        {
            int temperatura;
            
            // Le pedimos al usuario que introduzca la temperatura
            Console.WriteLine("Introduce la temperatura del agua en ºC:");
            temperatura = int.Parse(Console.ReadLine());

            // Evaluamos el valor de la variable temperatura
            if (temperatura <= 0)
            {
                Console.WriteLine("El agua se encuentra en estado sólido.");
            } else if (temperatura < 100){
                Console.WriteLine("El agua no se encuentra en estado líquido");
            } else
            {
                Console.WriteLine("El agua se encuentra en estado gaseoso");
            }
        }
    }
}
