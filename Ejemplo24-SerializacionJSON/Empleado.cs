using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo24_SerializacionJSON
{
    [Serializable]
    public class Empleado
    {
        // Atributos
        private string nombre;
        private string apellidos;
        private string departamento;
        private DateTime fechaNacimiento;


        // Constructores
        public Empleado()
        { 
        }

        public Empleado(string nombre, string apellidos, string departamento, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.departamento = departamento;
            this.fechaNacimiento = fechaNacimiento;
        }

        // Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }


        // Sobrescribo el método ToString
        public override string ToString()
        {
            return $"Nombre: {this.nombre}; Apellidos: {this.apellidos};"
                + $" Departamento: {this.departamento}; Fecha Nacimiento: {this.fechaNacimiento.ToLongDateString()}";
        }
    }
}