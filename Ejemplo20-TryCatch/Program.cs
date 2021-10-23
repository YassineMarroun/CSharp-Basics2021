using System;

namespace Ejemplo20_TryCatch
{
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
                
                try
                {
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
                        case 4:
                            Console.WriteLine("Introduce el valor del dividendo:");
                            double dividendo = double.Parse(Console.ReadLine());
                            Console.WriteLine("Introduce el valor del divisor:");
                            double divisor = double.Parse(Console.ReadLine());
                            if (divisor == 0)
                            {
                                // Lanzo una excepción
                                throw new DivideByZeroException();
                            }
                            Console.WriteLine("El resultado de la división es {0}", dividendo / divisor);
                            break;
                    }
                } catch (FormatException e)
                {
                    Console.WriteLine("Error. El valor introducido no es correcto.");
                    Console.WriteLine(e.StackTrace);
                } catch (DivideByZeroException)
                {
                    Console.WriteLine("No se puede dividir entre 0");
                } catch (Exception)
                {
                    Console.WriteLine("Ha ocurrido un problema");
                }
            }
            Console.WriteLine("Fin del programa");
        }
    }
}
