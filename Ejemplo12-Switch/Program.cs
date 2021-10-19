using System;

namespace Ejemplo12_Switch
{
    /*
     * Ejemplos de uso de la instrucción Switch
     */
    class Program
    {
        static void Main(string[] args)
        {
            int estado;
            Console.WriteLine("Introduce estado: (0) Inactivo; (1) Activo");
            estado = int.Parse(Console.ReadLine());

            switch (estado)
            {
                case 0:
                    Console.WriteLine("Se encuentra en estado inactivo");
                    break;
                case 1:
                    Console.WriteLine("Se encuentra en estado activo");
                    break;
                default:
                    Console.WriteLine("Estado inválido");
                    break;
            }


            int nota;
            Console.WriteLine("Introduce la nota:");
            nota = int.Parse(Console.ReadLine());

            switch (nota)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Suspenso");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("Aprobado");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Notable");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Sobresaliente");
                    break;
                default:
                    Console.WriteLine("Nota incorrecta");
                    break;
            }
        }
    }
}
