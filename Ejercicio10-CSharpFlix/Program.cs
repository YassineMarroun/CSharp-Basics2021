using System;
using System.Collections.Generic;

namespace Ejercicio10_CSharpFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            // Preguntamos nombre al usuario para darle la bienvenida
            Console.WriteLine("Hola, ¿Cómo te llamas?");
            string usuario = Console.ReadLine();
            Console.WriteLine("Bienvenido a CSharpFlix, " + usuario);

            // Creamos una lista de películas
            List<Pelicula> peliculas = new List<Pelicula>();
            do{
                PintaMenu();   
                Console.WriteLine("Introduce una opción (0-3)");
                opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                        // Listar películas
                        ListarPelicula(peliculas);
                        break;
                    case 2:
                        // Añadir película
                        AnnadirPelicula(peliculas);
                        break;
                    case 3:
                        // Eliminar películas
                        EliminarPelicula(peliculas);
                        break;
                }

            } while (opcion != 0);
            Console.WriteLine($"Adiós {usuario}, ¡Hasta la vista!");
        }


        private static void PintaMenu()
        {
             Console.WriteLine("----------------------------");
                    Console.WriteLine("|        CSharpFlix        |");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("|  (1) Listar películas    |");
                    Console.WriteLine("|  (2) Añadir película     |");
                    Console.WriteLine("|  (3) Eliminar película   |");
                    Console.WriteLine("|  (0) Salir del programa  |");
                    Console.WriteLine("----------------------------");
        }


        private static void ListarPelicula(List<Pelicula> peliculas)
        {
            // Comprobamos que existan películas
            if (peliculas.Count > 0)
            {
                // Hay películas y las mostramos
                Console.WriteLine("Listado de películas");
                Console.WriteLine("--------------------");
                foreach(Pelicula peli in peliculas)
                {
                    Console.WriteLine(peli);
                }
            } else
            {
                // La lista de películas está vacía
                Console.WriteLine("No existen películas en el sistema.");
            }
        }


        private static void AnnadirPelicula(List<Pelicula> peliculas)
        {
            // Creamos una película y la añadimos a la lista
            Pelicula peliNueva = new Pelicula();
            Console.WriteLine("Introduce el título de la película: ");
            peliNueva.Titulo = Console.ReadLine();
            Console.WriteLine("Introduce la duración en minutos: ");
            peliNueva.Duracion = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la descripción: ");
            peliNueva.Descripcion = Console.ReadLine();
            peliNueva.Fecha = DateTime.Today;                           
            Console.WriteLine("Introduce el nombre del director/a: ");
            peliNueva.Director = Console.ReadLine();
            Console.WriteLine("Introduce el género de la película: ");
            peliNueva.Genero = Console.ReadLine();
            peliculas.Add(peliNueva);
        }


        private static void EliminarPelicula(List<Pelicula> peliculas)
        {
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
                    if (peliculas[i].Titulo.Contains(titulo))
                    {
                        // El título contiene el criterio de búsqueda
                        // Le preguntamos si desea borrarla
                        Console.WriteLine("¿Estás seguro de que deseas borrar la siguiente película (s/n)?");
                        Console.WriteLine(peliculas[i]);
                        char respuesta = char.Parse(Console.ReadLine().ToLower());
                        if (respuesta == 's')
                        {
                            // La borramos
                            peliculas.RemoveAt(i);
                        }
                    }
                }
            }
        }
    }
}
