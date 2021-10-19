using System;

namespace Ejemplo02_IntroduccionDatosConsola
{
    /*
     * En este ejemplo vamos a introducir por teclado los datos
     * en lugar de tenerlos fijos en el propio programa
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Le indicamos al usuario que debe introducir un mensaje
            Console.WriteLine("Por favor, escribe tu mensaje y pulsa Enter");

            // Recogemos el mensaje y lo almacenamos en la variable mensaje
            string mensaje = Console.ReadLine();

            // Mostramos el contenido de ese mensaje
            Console.WriteLine("Aquí está tu mensaje");
            Console.WriteLine(mensaje);
        }
    }
}
