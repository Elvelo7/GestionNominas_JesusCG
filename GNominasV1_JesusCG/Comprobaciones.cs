using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNominasV1_JesusCG
{
    /// <summary>
    /// Validaciones sobre los datos de Entrada
    /// Independientes de la Interfaz
    /// Errores tratados con Excepciones
    /// </summary>
    public static class Comprobaciones
    {
        /// <summary>
        /// Método que realiza la conversión de una cadena a un número de horas válido
        /// </summary>
        /// <param name="cadena">Cadena de caracteres a convertir</param>
        /// <returns>Horas Trabajadas</returns>
        /// <exception cref="Exception">Errores de las Horas</exception>
        public static int ValidarHoras(string cadena)
        {
            // CONSTANTES
            const int LIMITE = 60;

            // VARIABLES
            int numeroHoras = 0;

            // PROCESO - Detección de errores
            // Cadena Vacía
            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena Vacía");
            // Conversión
            numeroHoras = Convert.ToInt32(cadena);
            // Rango de Horas
            if (numeroHoras <= 0) throw new Exception("Horas inferiores o iguales a 0");
            if (numeroHoras > LIMITE) throw new Exception($"Horas superiores a {LIMITE} horas");

            // SALIDA - Método
            return numeroHoras;
        }

        /// <summary>
        /// Método de Conversión y Validación del Salario por Hora
        /// </summary>
        /// <param name="cadena">Cadena que representa el salario por hora</param>
        /// <returns>Salario por hora</returns>
        /// <exception cref="Exception">Errores</exception>
        public static float ValidarSalarioHora(string cadena)
        {
            // CONSTANTES
            const float SALARIO_MAX = 22.5f;
            const float SALARIO_MIN = 1.0f;

            // RECURSOS LOCALES
            float euros = 0.0f;

            // PROCESO - Detección de errores
            // Detección de la cadena vacía
            if (string.IsNullOrEmpty(cadena)) throw new Exception("Cadena vacía");
            // Conversión del valor numérico
            euros = Convert.ToSingle(cadena);
            // Rango de valores
            if (euros < SALARIO_MIN) throw new Exception($"Valor inferior a {SALARIO_MIN} Euros");
            if (euros > SALARIO_MAX) throw new Exception($"Valor superior a {SALARIO_MAX} Euros");

            // SALIDA - Método
            return euros;
        }
    }
}
