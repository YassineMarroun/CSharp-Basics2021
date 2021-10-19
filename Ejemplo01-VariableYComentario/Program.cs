using System;

namespace Ejemplo01_VariableYComentario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Este es un comentario de una línea

            /*
             * Este comentario
             * puede ocupar
             * varias líneas
            */

            // Declaro una varible de tipo cadena
            string saludo;

            // Asignar un valor a la variable mensaje
            saludo = "Hola desde el curso de C# de la UNED";

            // Declaro y asigno valor a una variable
            string despedida = "Hasta el viernes";

            // Mostramos por pantalla el valor de las variables
            Console.WriteLine(saludo);
            Console.WriteLine(despedida);

            // Modificar el valor de despedida
            despedida = "Adios";
            Console.WriteLine(despedida);

        }
    }
}
