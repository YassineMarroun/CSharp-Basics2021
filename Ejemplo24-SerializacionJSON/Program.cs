using System;
using System.Text.Json;
using System.IO;

namespace Ejemplo24_SerializacionJSON
{
    /*
     * Ejemplo de serialización en JSON
     */
    class Program
    {
        // Ruta del archivo
        const string RutaEmpleadoJSON =  @"C:\Users\yasma2\OneDrive - UNED\.ProyectosGITHUB\CSharp - Basics2021\empleado.json";
        static void Main(string[] args)
        {
            Empleado emp = new Empleado("Albert", "Einstein", "Física", new DateTime(1879,3,14));

            // Serializamos el objeto a una cadena JSON y la guardamos en archivo
            string cadenaJSON = JsonSerializer.Serialize(emp);
            File.WriteAllText(RutaEmpleadoJSON, cadenaJSON);

            // Leemos del archivo la cadena con el JSON
            string cadenaArchivo = File.ReadAllText(RutaEmpleadoJSON);
            // La deserializamos, la convertimos en un objeto
            Empleado almacenado = JsonSerializer.Deserialize<Empleado>(cadenaArchivo);

            // Mostramos el objeto recuperado
            Console.WriteLine("Empleado-> " + almacenado);
        }
    }
}
