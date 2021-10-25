using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Ejercicio10_CSharpFlix
{
    class Program
    {
        // Ruta del archivo JSON que contiene las películas
        const string RutaJSONpeliculas = @"C:\Users\yasma2\OneDrive - UNED\.ProyectosGITHUB\CSharp - Basics2021\peliculas.json";
        static void Main(string[] args)
        {
            int opcion;
            // Preguntamos nombre al usuario para darle la bienvenida
            Console.WriteLine("Hola, ¿Cómo te llamas?");
            string usuario = Console.ReadLine();
            Console.WriteLine("Bienvenido a CSharpFlix, " + usuario);

            // Obtenemos una lista de películas
            List<Pelicula> peliculas = CargarPeliculasArchivo();
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
                    default:
                        // Opción incorrecta
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

            } while (opcion != 0);
            // Nos despedimos del usuario
            Console.WriteLine($"Adiós {usuario}, ¡Hasta la vista!");
            // Guardamos las películas en archivo
            GuardarPeliculasArchivo(peliculas);
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
            } else
            {
                // No hay películas en la lista
                Console.WriteLine("No existen películas en el sistema");
            }
        }


        // Cargamos las películas desde un archivo
        private static List<Pelicula> CargarPeliculasArchivo()
        {
            List<Pelicula> pelisCargadas;

            if (File.Exists(RutaJSONpeliculas))
            {
                // Leemos el archivo y lo deserializamos a una lista
                string cadenaJSON = File.ReadAllText(RutaJSONpeliculas);
                pelisCargadas = JsonSerializer.Deserialize<List<Pelicula>>(cadenaJSON);
            } else
            {
                pelisCargadas = new List<Pelicula>();
            }

            return pelisCargadas;
        }


        // Guardamos las pelíulas en archivo
        private static void GuardarPeliculasArchivo(List<Pelicula> peliculas)
        {
            // Serializamos la lista a una cadena JSON y la guardamos
            string cadenaJSON = JsonSerializer.Serialize(peliculas);
            File.WriteAllText(RutaJSONpeliculas, cadenaJSON);
        }
    }
}
