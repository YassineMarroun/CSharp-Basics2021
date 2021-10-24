using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10_CSharpFlix
{
    class Video
    {
        // Atributos
        private string titulo;
        private int duracion;
        private string descripcion;
        private DateTime fecha;


        // Constructores
        public Video()
        {
        }

        public Video(string titulo, int duracion, string descripcion, DateTime fecha)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.descripcion = descripcion;
            this.fecha = fecha;
        }


        // Propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }


        // Sobrescribo el método ToString
        public override string ToString()
        {
            return $"Título: {this.titulo}; Duración: {this.duracion} minutos; "
                + $"Descripción: {this.descripcion}; Fecha: {this.fecha.ToShortDateString()}";
        }

    }
}