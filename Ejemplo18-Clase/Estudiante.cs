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
        public Estudiante()
        {
        }

        public Estudiante(int idPersona, string nombre, string apellidos, DateTime fechaNacimiento, string curso) :base(idPersona, nombre, apellidos, fechaNacimiento)
        {
            this.curso = curso;
        }

        public string Curso { get => curso; set => curso = value; }

        public override string ToString()
        {
            return base.ToString() + $"; Curso: {this.curso}";
        }
    }
}