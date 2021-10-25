using System;
using System.Xml.Serialization;
using System.IO;

namespace Ejemplo23_SerializacionXML
{
    /*
     * Ejemplo de serialización a XML
     */
    class Program
    {
        // Ruta del archivo
        const string RutaEmpleadoXML =  @"C:\Users\yasma2\OneDrive - UNED\.ProyectosGITHUB\CSharp - Basics2021\empleado.xml";
        static void Main(string[] args)
        {
            Empleado emp = new Empleado("Albert", "Einstein", "Física", new DateTime(1879,3,14));

            // Lo guardamos en XML
            XmlSerializer writer = new XmlSerializer(typeof(Empleado));
            StreamWriter archivoGuardar = new StreamWriter(RutaEmpleadoXML);
            writer.Serialize(archivoGuardar, emp);
            archivoGuardar.Close();

            // Recuperamos el objeto del archivo XML
            XmlSerializer reader = new XmlSerializer(typeof(Empleado));
            StreamReader archivoLeer = new StreamReader(RutaEmpleadoXML);
            Empleado almacenado = (Empleado)reader.Deserialize(archivoLeer);
            archivoLeer.Close();

            // Mostrmos el objeto recuperado
            Console.WriteLine("Empleado-> " + almacenado);
        }
    }
}
