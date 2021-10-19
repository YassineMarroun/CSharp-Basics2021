using System;

namespace Ejemplo13_While
{
    /*
     * Ejemplo de calculadora con menú
     * usando una instrucción while
     */
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 5)
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("1) Sumar");
                Console.WriteLine("2) Restar");
                Console.WriteLine("3) Multiplicar");
                Console.WriteLine("4) Dividir");
                Console.WriteLine("5) Salir del programa");
                Console.WriteLine("Introduce una opción (1-5):");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Introduce el valor del primer sumando:");
                        double sumando1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el valor del segundo sumando:");
                        double sumando2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la suma es {0}", sumando1 + sumando2);
                        break;
                    case 2:
                        Console.WriteLine("Introduce el valor del minuendo:");
                        double minuendo = double.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el valor del sustraendo:");
                        double sustraendo = double.Parse(Console.ReadLine());
                        Console.WriteLine("El resultado de la resta es {0}", minuendo - sustraendo);
                        break;
                }
            }
            Console.WriteLine("Fin del programa");
        }
    }
}
