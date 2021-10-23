using System;

namespace Ejemplo18_Clase
{
    /*
     * Ejemplo de uso con clases
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Creo un objeto de la clase Persona
            Persona persona1 = new Persona(1, "Albert", "Einstein", new DateTime(1879,3,14));
            Console.WriteLine(persona1.Apellidos + " " + persona1.Nombre);

            Empleado empleado1 = new Empleado(2, "Ana", "López", new DateTime(1995,8,10), 25000);
            Estudiante estudiante1 = new Estudiante(3, "Iker", "García", new DateTime(2000,11,30), "CSharp");

            Persona persona2 = new Estudiante();
            persona2.Nombre = "María";
            persona2.Apellidos = "Pérez";
            persona2.IdPErsona = 4;
            persona2.FechaNacimiento = new DateTime(2002, 2, 28);

            Console.WriteLine($"Salario antes del aumento: {empleado1.Salario} euros");
            empleado1.SubirSalario(2000);
            Console.WriteLine($"Salario después del aumento: {empleado1.Salario} euros");

            Console.WriteLine($"La empleada {empleado1.Nombre} tiene {empleado1.CalcularEdad()} años.");
            Console.WriteLine($"El estudiante {estudiante1.Nombre} tiene {estudiante1.CalcularEdad()} años.");

            Console.WriteLine(persona1);
            Console.WriteLine(empleado1);
            Console.WriteLine(estudiante1);

            Persona persona3 = empleado1;
            Persona persona4 = estudiante1;

            CompruebaObjeto(persona1);
            CompruebaObjeto(persona3);
            CompruebaObjeto(persona4);
        }


        private static void CompruebaObjeto(Object objeto)
        {
            if (objeto is Empleado)
            {
                Console.WriteLine("El objeto es de la clase Empleado -> " + objeto);
            } else if (objeto is Estudiante)
            {
                Console.WriteLine("El objeto es de la clase Estudiante -> " + objeto);
            } else
            {
                Console.WriteLine("No es ni Empleado ni Estudiante -> " + objeto);
            }
        }
    }
}
