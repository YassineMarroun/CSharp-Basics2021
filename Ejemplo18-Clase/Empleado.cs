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


        // Propiedades
        public double Salario { get => salario; set => salario = value; }


        // Métodos
        public void SubirSalario(int cantidad)
        {
            this.salario += cantidad;
        }

        public void BajarSalario(int cantidad)
        {
            this.salario -= cantidad;
        }
    }
}