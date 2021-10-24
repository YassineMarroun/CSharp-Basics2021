using System;
using System.Collections.Generic;
using System.IO;

namespace Ejemplo21_ArchivoTexto
{
    /*
     * Ejemplo con archivo de texto plano
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Creo un string con la ruta del archivo
            string rutaArchivo = @"C:\Users\yasma2\OneDrive - UNED\.ProyectosGITHUB\CSharp - Basics2021\nombres.txt";
            
            // Declaro las variables que usaré
            string cadenaNombres = null;
            string[] arrayNombres;
            List<string> listaNombres;
            
            try
            {
                // Leemos el archivo
                StreamReader sr = new StreamReader(rutaArchivo);
                cadenaNombres = sr.ReadLine();
                sr.Close();
            } catch (FileNotFoundException)
            {
                Console.WriteLine("El archivo no existe");
            }
            

            // Muestro la información recuperada
            Console.WriteLine(cadenaNombres);

            if (cadenaNombres != null)
            {
                // El archivo existe y contiene nombres
                // Pasamos la cadena del archivo a un array de string
                // indicando que el separador es la coma (,)
                arrayNombres = cadenaNombres.Split(',');

                //Creamos una lista a partir del array
                listaNombres = new List<string>(arrayNombres);
            } else
            {
                // No existe el archivo o no tiene nombres
                listaNombres = new List<string>();
            }

            char opcion;
            do
            {
                Console.WriteLine("(L)istar nombres");
                Console.WriteLine("(A)ñadir nombre");
                Console.WriteLine("(S)alir del programa");
                Console.WriteLine("Introduce una opción [L, A, S]:");
                opcion = char.Parse(Console.ReadLine().ToLower());

                switch(opcion)
                {
                    case 'l':
                        // Listar
                        for (int i = 0; i < listaNombres.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {listaNombres[i]}");
                        }
                        break;
                    case 'a':
                        // Añadir
                        Console.WriteLine("Introduce un nuevo nombre:");
                        listaNombres.Add(Console.ReadLine());
                        break;
                    case 's':
                        // Salir del programa
                        // Convertimos el List en un array
                        arrayNombres = listaNombres.ToArray();
                        // Unimos los nombres del array en una cadena utilizando (,) como separador
                        cadenaNombres = String.Join(',', arrayNombres);
                        // Guardamos el archivo
                        StreamWriter sw = new StreamWriter(rutaArchivo);
                        sw.WriteLine(cadenaNombres);
                        sw.Close();
                        Console.WriteLine("Saliendo del programa. Hasta la vista.");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
            } while (opcion != 's');
        }
    }
}
