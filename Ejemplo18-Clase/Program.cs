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
            Console.WriteLine(persona1);

            Empleado empleado1 = new Empleado(2, "Ana", "López", new DateTime(1995,8,10), 25000);
        }
    }
}
