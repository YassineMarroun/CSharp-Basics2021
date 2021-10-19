using System;

namespace Ejemplo03_AsignacionesEnteros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Las líneas que empiezan con // son comentarios, no se ejecutan
            // Declaramos las variables de tipo entero a, b y c
            int a, b, c;

            a = 7; // A la variable a le asignamos un valor
            b = a; // A la variable b le asignamos el valor de a
            c = b; // A la variable c le asignamos el valor de b y a b se lo incrementamos en 1
            b = a + b * c; // A la variable b le asignamos el valor de una operación
            c = a >= 100 ? b : c / 10; // A c le damos un valor en función de una condición
            a = (int)Math.Sqrt(b * b + c * c); // Utilizamos una función matemática compleja

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }
    }
}
