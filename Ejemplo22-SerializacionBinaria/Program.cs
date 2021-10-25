using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Ejemplo22_SerializacionBinaria
{
    /*
     * Ejemplo de serailización/deserialización de objetos
     * en arvhio binario
     */
    class Program
    {
        // Ruta del archivo
        const string RutaEmpleado =  @"C:\Users\yasma2\OneDrive - UNED\.ProyectosGITHUB\CSharp - Basics2021\empleado.bin";
        const string RutaEmpleados =  @"C:\Users\yasma2\OneDrive - UNED\.ProyectosGITHUB\CSharp - Basics2021\empleados.bin";
        static void Main(string[] args)
        {
            Empleado emp = new Empleado("Albert", "Einstein", "Física", new DateTime(1879,3,14));

            // Abrimos el archivo, si no existe lo crea
            Stream SaveFileStream = File.Create(RutaEmpleado);
            // Serializar el objeto
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(SaveFileStream, emp);
            // Cerramos el archivo
            SaveFileStream.Close();

            // Declaro el objeto que recuperaré
            Empleado rec = null;

            if (File.Exists(RutaEmpleado))
            {
                // Existe el archivo
                // Abro el archivo
                Stream openFileStream = File.OpenRead(RutaEmpleado);
                // Deserializo el archivo
                BinaryFormatter deserializer = new BinaryFormatter();
                rec = (Empleado)deserializer.Deserialize(openFileStream);
                // Cierro el archivo
                openFileStream.Close();
            }

            // Muestro los datos
            Console.WriteLine("Empleado-> " + rec);

            // Lista de empleados
            List<Empleado> empleados = new List<Empleado>
            {
                new Empleado("Mireia", "Belmonte", "Deporte", new DateTime(1990,11,10)),
                new Empleado("Bill", "Gates", "Informática", new DateTime(1955,10,28)),
                new Empleado("Antonio", "López", "Arte", new DateTime(1936,1,6))
            };

            // Abrimos el archivo, si no existe lo crea
            Stream SaveFileStream2 = File.Create(RutaEmpleados);
            // Serializar el objeto
            BinaryFormatter serializer2 = new BinaryFormatter();
            serializer2.Serialize(SaveFileStream2, empleados);
            // Cerramos el archivo
            SaveFileStream2.Close();
        }
    }
}
