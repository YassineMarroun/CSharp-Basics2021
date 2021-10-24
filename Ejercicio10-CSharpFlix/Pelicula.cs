using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10_CSharpFlix
{
    class Pelicula:Video
    {
        // Atributos
        private string director;
        private bool vista;
        private string genero;


        // Constructores
        public Pelicula()
        {
        }

        public Pelicula(string titulo, int duracion, string descripcion, DateTime fecha, string director, bool vista, string genero)
            : base(titulo, duracion, descripcion, fecha)
        {
            this.director = director;
            this.vista = vista;
            this.genero = genero;
        }


        // Propiedades
        public string Director { get => director; set => director = value; }
        public bool Vista { get => vista; set => vista = value; }
        public string Genero { get => genero; set => genero = value; }


         // Sobrescribo el método ToString
        public override string ToString()
        {
            return base.ToString() + $"; Director: {this.director}; Vista: {this.vista}; Genero: {this.genero}";
        }
    }
}