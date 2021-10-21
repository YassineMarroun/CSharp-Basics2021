using System;
using System.Collections.Generic;

namespace Ejercicio10_CSharpFlix
{
    class Program
    {
        struct Pelicula
        {
            public string titulo;
            public string director;
            public int duracion;
        }
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Hola, ¿Cómo te llamas?");
            string usuario = Console.ReadLine();
            Console.WriteLine("Bienvenido a CSharpFlix, " + usuario);

            List<Pelicula> peliculas = new List<Pelicula>();
            do{
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("|        CSharpFlix        |");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("|  (1) Listar películas    |");
                    Console.WriteLine("|  (2) Añadir película     |");
                    Console.WriteLine("|  (3) Eliminar película   |");
                    Console.WriteLine("|  (4) Salir del programa  |");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("Introduce una opción (1-4)");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            // Listamos las películas
                            Console.WriteLine("Listado de películas");
                            Console.WriteLine("--------------------");
                            foreach(Pelicula peli in peliculas)
                            {
                                Console.WriteLine("Titulo: {0}; Director: {1}; Duración: {2} minutos.",
                                    peli.titulo, peli.director, peli.duracion);
                            }
                            break;
                        case 2:
                            Pelicula peliNueva = new Pelicula();
                            Console.WriteLine("Introduce el título de la película: ");
                            peliNueva.titulo = Console.ReadLine();
                            Console.WriteLine("Introduce el nombre del director/a: ");
                            peliNueva.director = Console.ReadLine();
                            Console.WriteLine("Introduce la duración en minutos: ");
                            peliNueva.duracion = int.Parse(Console.ReadLine());
                            peliculas.Add(peliNueva);
                            break;
                        case 3:
                            // Eliminar películas
                            // Comprobamos que existen películas
                            if (peliculas.Count > 0)
                            {
                                // Hay películas
                                // Le pedimos el nombre de la película que desea eliminar
                                Console.WriteLine("Introduce el título de la película a eliminar: ");
                                string titulo = Console.ReadLine();
                                // Recorremos la lista de películas
                                for (int i = peliculas.Count-1; i >= 0; i--)
                                {
                                    if (peliculas[i].titulo.Contains(titulo))
                                    {
                                        // El título contiene el criterio de búsqueda
                                        // Le preguntamos si desea borrarla
                                        Console.WriteLine("¿Estás seguro de que deseas borrar la siguiente película (s/n)?");
                                        Console.WriteLine("Titulo: {0}; Director: {1}; Duración: {2} minutos.",
                                            peliculas[i].titulo, peliculas[i].director, peliculas[i].duracion);
                                        char respuesta = char.Parse(Console.ReadLine().ToLower());
                                        if (respuesta == 's')
                                        {
                                            // La borramos
                                            peliculas.RemoveAt(i);
                                        }
                                    }
                                }
                            }
                            break;
                    }

            } while (opcion != 0);
            Console.WriteLine($"Adiós {usuario}, ¡Hasta la vista!");
        }
    }
}
