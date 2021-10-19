using System;

namespace Ejercicio01_Bienvenida
{
    /*
     * Programa que nos pide nuestro nombre y después nos dé
     * la bienvenida incluyendo el nombre introducido.
     * Por ejemplo, Bienvenido, Ángel
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Le indicamos al usuario que debe introducir un nombre
            Console.WriteLine("Por favor, escribe tu nombre y pulsa Enter");

            // Recogemos el nombre y lo almacenamos en la variable nombre
            string nombre = Console.ReadLine();

            // Mostramos el un mensaje dando la bienvenida:
            Console.Write("Bienvenida/o, ");
            Console.WriteLine(nombre);
        }
    }
}
