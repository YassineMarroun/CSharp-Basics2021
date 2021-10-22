using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo18_Clase
{
    // Clase Empleado
    class Empleado:Persona
    {
        // Atributos
        private double salario;

        // Constructores
        public Empleado(int idPersona, string nombre, string apellidos, DateTime fechaNacimiento, double salario) :base(idPersona, nombre, apellidos, fechaNacimiento)
        {
            this.salario = salario;
        }
    }
}