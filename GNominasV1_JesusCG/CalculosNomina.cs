using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNominasV1_JesusCG
{
    public static class CalculosNomina
    {
        /// <summary>
        /// Cálculo de las Horas Extra realizadas
        /// </summary>
        /// <param name="horas">Horas Trabajadas</param>
        /// <returns>Horas Extra</returns>
        public static int HorasExtra(int horas)
        {
            // CONSTANTES
            const int HORAS_SEMANALES = 35;

            // RECURSOS LOCALES
            int extra = 0;
            
            // PROCESO
            if (horas > HORAS_SEMANALES) extra = horas - HORAS_SEMANALES;

            // SALIDA - Método
            return extra;
        }

        /// <summary>
        /// Cálculo de los Impuestos a aplicar
        /// </summary>
        /// <param name="bruto">Salario Bruto</param>
        /// <returns>Impuestos</returns>
        public static float Impuestos(float bruto)
        {
            // CONSTANTES
            const float PORCENTAJE_IMP = 0.16f;

            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return bruto * PORCENTAJE_IMP;
        }

        /// <summary>
        /// Cálculo del Salario Base del Trabajador
        /// </summary>
        /// <param name="horas">Horas Trabajadas</param>
        /// <param name="eurosHora">Salario por Hora Trabajada</param>
        /// <returns>Salario Base</returns>
        public static float SalarioBase(int horas, float eurosHora)
        {
            // CONSTANTES
            const int HORAS_SEMANALES = 35;

            // RECURSOS LOCALES
            float salario = 0;

            // PROCESO
            // El cálculo del salario base se realiza sobre las horas que no son extra
            if (horas > HORAS_SEMANALES) salario = HORAS_SEMANALES * eurosHora;
            else salario = horas * eurosHora;

            // SALIDA - Método
            return salario;
        }

        /// <summary>
        /// Cálculo del Salario Bruto del Trabajador
        /// </summary>
        /// <param name="salBase">Salario Base</param>
        /// <param name="salExtra">Salario Extra</param>
        /// <returns>Salario Bruto</returns>
        public static float SalarioBruto(float salBase, float salExtra)
        {
            // CONSTANTES
            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return salBase + salExtra;
        }

        /// <summary>
        /// Cálculo del Salario Extra del Trabajador
        /// </summary>
        /// <param name="horas">Horas Extra</param>
        /// <param name="eurosHora">Salario por Hora Trabajada</param>
        /// <returns></returns>
        public static float SalarioExtra(int horas, float eurosHora)
        {
            // CONSTANTES
            const float INCR_EXTRA = 1.5f;

            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return horas * eurosHora * INCR_EXTRA;
        }

        /// <summary>
        /// Cálculo del Salario Neto del Trabajador
        /// </summary>
        /// <param name="bruto">Salario Bruto</param>
        /// <param name="tasas">Impuestos a aplicar</param>
        /// <returns>Salario Neto</returns>
        public static float SalarioNeto(float bruto, float tasas)
        {
            // CONSTANTES
            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return bruto - tasas;
        }
    }
}
