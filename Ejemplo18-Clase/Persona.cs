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


        // Constructores
        public Persona()
        {
        }
        
        public Persona(int idPersona, string nombre, string apellidos, DateTime fechaNacimiento)
        {
            this.idPersona = idPersona;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
        }


        // Propiedades
        public int IdPErsona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }


        // Métodos
        public int CalcularEdad()
        {
            int edad;
            DateTime hoy = DateTime.Today;

            edad = hoy.Year - this.fechaNacimiento.Year;

            // Con este if comprobamos si ya ha cumplido los años
            // en el año actual, so no los ha cumplido, le restamos 1
            if (hoy.Month < this.fechaNacimiento.Month)
            {
                 // Los cumple en un mes posterior al actual
                 edad--;
            } else if (hoy.Month == this.fechaNacimiento.Month)
            {
                if (hoy.Day < this.fechaNacimiento.Day)
                {
                    // Los cumple este mes pero aún no ha llegado el día
                    edad--;
                }
            }

            return edad;
        }
    }
}