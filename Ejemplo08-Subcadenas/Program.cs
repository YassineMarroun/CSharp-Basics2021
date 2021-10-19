using System;

namespace Ejemplo08_Subcadenas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tenemos una cadena original de la que extraeremos la información
            string informacion = "Aquí está la información. Nombre: Diego; Apellido: Velazquez; Localidad: Sevilla;";
            Console.WriteLine("Información original: " + informacion);

            // Vamos a obtener la información del nombre
            // Localizamos dónde comienza la etiqueta Nombre: y le sumamos su longitud para saber
            // dónde comienza el valor de nombre
            int inicioNombre = informacion.IndexOf("Nombre:") + "Nombre:".Length;
            // Encontramos donde termina el valor de nombre buscando el ; a partir del nombre
            int finNombre = informacion.IndexOf(";", inicioNombre);
            // Calculamos el tamaño del valor de nombre
            int tamannoNombre = finNombre - inicioNombre;
            // Obtenemos la subcadena del nombre y le quitamos los espacios en blanco
            string nombre = informacion.Substring(inicioNombre, tamannoNombre).Trim();
            //Mostramos el nombre
            Console.WriteLine("Nombre: " + nombre);


            // Vamos a obtener la información del apellido
            // Localizamos dónde comienza la etiqueta Apellido: y le sumamos su longitud para saber
            // dónde comienza el valor de apellido
            int inicioApellido = informacion.IndexOf("Apellido:") + "Apellido:".Length;
            // Encontramos donde termina el valor de apellido buscando el ; a partir del apellido
            int finApellido = informacion.IndexOf(";", inicioApellido);
            // Calculamos el tamaño del valor de apellido
            int tamannoApellido = finApellido - inicioApellido;
            // Obtenemos la subcadena del apellido y le quitamos los espacios en blanco
            string apellido = informacion.Substring(inicioApellido, tamannoApellido).Trim();
            //Mostramos el apellido
            Console.WriteLine("Apellido: " + apellido);


            // Vamos a obtener la información de la localidad
            // Localizamos dónde comienza la etiqueta Localidad: y le sumamos su longitud para saber
            // dónde comienza el valor de localidad
            int inicioLocalidad = informacion.IndexOf("Localidad:") + "Localidad:".Length;
            // Encontramos donde termina el valor de localidad buscando el ; a partir de la localidad
            int finLocalidad = informacion.IndexOf(";", inicioLocalidad);
            // Calculamos el tamaño del valor de localidad
            int tamannoLocalidad = finLocalidad - inicioLocalidad;
            // Obtenemos la subcadena de la localidad y le quitamos los espacios en blanco
            string localidad = informacion.Substring(inicioLocalidad, tamannoLocalidad).Trim();
            //Mostramos la localidad
            Console.WriteLine("Localidad: " + localidad);
        }
    }
}
