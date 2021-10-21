using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo18_Clase
{
    // Clase Persona
    class Persona
    {
        // Atributos
        int idPersona;
        string nombre;
        string apellidos;
        DateTime fechaNacimiento;

        public Persona(int idPersona, string nombre, string apellidos, DateTime fechaNacimiento)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}