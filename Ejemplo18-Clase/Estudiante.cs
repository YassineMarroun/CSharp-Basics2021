using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo18_Clase
{
    // Clase Empleado
    class Estudiante:Persona
    {
        // Atributos
        private string curso;

        // Constructores
        public Estudiante(int idPersona, string nombre, string apellidos, DateTime fechaNacimiento, string curso) :base(idPersona, nombre, apellidos, fechaNacimiento)
        {
            this.curso = curso;
        }
    }
}