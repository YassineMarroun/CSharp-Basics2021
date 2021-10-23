using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo19_ClaseEstatica
{

    static class ConvertidorTemperatura
    {
        /// <summary>
        /// Convierte una temperatura de grados Celsius a Fahrenheit
        /// </summary>
        /// <param name = "temperaturaCelsius"></param>
        /// <returns> Valor de temperatura en ºF</returns>
        public static double CelsiusAFahrenheit(double temperaturaCelsius)
        {
            //Convertir de Celsius a Fahrenheit
            double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

            return temperaturaFahrenheit;
        }


        /// <summary>
        /// Convierte una temperatura en grados Fahrenheit a Celsius
        /// </summary>
        /// <param name = "temperaturaFahrenheit"></param>
        /// <returns> Valor de temperatura en ºC</returns>
        public static double FahrenheitACelsius(double temperaturaFahrenheit)
        {
            // Convertir de Fahrenheit a Celsius
            double temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

            return temperaturaCelsius;
        }
    }
}