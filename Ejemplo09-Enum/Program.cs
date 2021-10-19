using System;

namespace Ejemplo09_Enum
{
    /*
     * Ejemplo para trabajar con enumerados
     */
    
    enum Estacion
    {
        Primavera,
        Verano,
        Otonno,
        Invierno
    }
    class Program
    {
        static void Main(string[] args)
        {
            Estacion actual = Estacion.Otonno;
            Estacion siguiente = (Estacion)3;

            Console.WriteLine(actual + " " + siguiente);

            Console.WriteLine("Introduce un valor de estación (0-3):");
            Estacion elegida = (Estacion)int.Parse(Console.ReadLine());
            Console.WriteLine("Tu estación es " + elegida);
            Console.WriteLine("Tu estación es {0}", elegida);
            Console.WriteLine($"Tu estacion es {elegida}");
        }
    }
}
