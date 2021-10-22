using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo18_Clase
{
    // Clase Persona
    class Persona
    {
        // Atributos
        private int idPersona;
        private string nombre;
        private string apellidos;
        private DateTime fechaNacimiento;

        public Persona(int idPersona, string nombre, string apellidos, DateTime fechaNacimiento)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}