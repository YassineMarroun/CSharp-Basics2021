using System;

namespace Ejemplo07_CaracteresEscape
{
    /*
     * Ejemplo de uso de cracter de escape
     * y formato cadena
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Primero mostramos la información sin usar carácter de escape
            Console.WriteLine("Nombre Apellido Localidad");
            Console.WriteLine("------ -------- ---------");
            Console.WriteLine("Diego Velázquez Sevilla");
            Console.WriteLine("Antonio López Tomelloso");
            Console.WriteLine("Francisco Carretero Tomelloso");


            // Ahora mostramos la información con uso del carácter de escape \t
            Console.WriteLine();
            Console.WriteLine("Nombre\tApellido\tLocalidad");
            Console.WriteLine("------\t--------\t---------");
            Console.WriteLine("Diego\tVelázquez\tSevilla");
            Console.WriteLine("Antonio\tLópez\tTomelloso");
            Console.WriteLine("Francisco\tCarretero\tTomelloso");


            // Ahora mostramos la información haciendo uso de algún método de la clase string
            Console.WriteLine();
            Console.WriteLine("Nombre".PadRight(15) + "Apellido".PadRight(15) + "Localidad".PadLeft(20));
            Console.WriteLine("------".PadRight(15) + "--------".PadRight(15) + "---------".PadLeft(20));
            Console.WriteLine("Diego".PadRight(15) + "Velázquez".PadRight(15) + "Sevilla".PadLeft(20));
            Console.WriteLine("Antonio".PadRight(15) + "López".PadRight(15) + "Tomelloso".PadLeft(20));
            Console.WriteLine("Francisco".PadRight(15) + "Carretero".PadRight(15) + "Tomelloso".PadLeft(20));
        }
    }
}
