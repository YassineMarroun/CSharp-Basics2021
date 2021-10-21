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
        }
    }
}
