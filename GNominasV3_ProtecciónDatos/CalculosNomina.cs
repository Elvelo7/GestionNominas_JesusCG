using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNominasV3_ProtecciónDatos
{
    internal class CalculosNomina
    {
        /// <summary>
        /// Calculo de las horas extra
        /// </summary>
        /// <param name="horasTrabajo"></param>
        /// <returns></returns>
        //public static int CalcularHorExtra(int horasTrabajo)
        //{
        //    // CONSTANTES
        //    const int HORAS_SEMANALES = 35;

        //    // RECURSOS LOCALES
        //    int extra = 0;

        //    // PROCESO
        //    if (horasTrabajo > HORAS_SEMANALES) extra = horasTrabajo - HORAS_SEMANALES;

        //    // SALIDA - Método
        //    return extra;
        //}

        /// <summary>
        /// Impuestos
        /// </summary>
        /// <param name="salarioBruto"></param>
        /// <returns></returns>
        public static float CalculoImpuestos(float salarioBruto)
        {
            // CONSTANTES
            const float PORCENTAJE_IMP = 0.16f;

            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return salarioBruto * PORCENTAJE_IMP;
        }

        /// <summary>
        /// Calculo Salario sin horas extra
        /// </summary>
        /// <param name="horasTrabajadas"></param>
        /// <param name="salarioHora"></param>
        /// <returns></returns>
        //public static float CalculoSalario(int horasTrabajadas, float salarioHora)
        //{
        //    // CONSTANTES
        //    const int HORAS_SEMANALES = 35;

        //    // RECURSOS LOCALES
        //    float salario = 0;

        //    // PROCESO
        //    // El cálculo del salario base se realiza sobre las horas que no son extra
        //    if (horasTrabajadas > HORAS_SEMANALES) salario = HORAS_SEMANALES * salarioHora;
        //    else salario = horasTrabajadas * salarioHora;

        //    // SALIDA - Método
        //    return salario;
        //}

        /// <summary>
        /// Calculo del salario Bruto
        /// </summary>
        /// <param name="salarioBase"></param>
        /// <param name="salarioExtra"></param>
        /// <returns></returns>
        public static float CalculoSalarioBruto(float salarioBase, float salarioExtra)
        {
            // CONSTANTES
            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return salarioBase + salarioExtra;
        }

        /// <summary>
        /// Calulo de salario de las horas extra
        /// </summary>
        /// <param name="horasExtra"></param>
        /// <param name="salarioHora"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static float CalculoSalarioExtra(int horasExtra, float salarioHora)
        {
            // CONSTANTES
            const float INCR_EXTRA = 1.5f;

            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return horasExtra * salarioHora * INCR_EXTRA;
        }

        /// <summary>
        /// Salario Neto
        /// </summary>
        /// <param name="salarioBrut"></param>
        /// <param name="impuest"></param>
        /// <returns></returns>
        public static float CalculoSalarioNeto(float salarioBrut, float impuest)
        {
            // CONSTANTES
            // RECURSOS LOCALES
            // PROCESO
            // SALIDA - Método
            return salarioBrut - impuest;
        }

    }
}
