using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNominasV1_JesusCG
{
    /// <summary>
    /// Métodos para Interactuar con el usuario (Entrada / Salida)
    /// </summary>
    public static class Interfaz
    {
        #region MÉTODOS DE ENTRADA DE DATOS
        /// <summary>
        /// Captación de las Horas Trabajadas - Interfaz Modo Texto
        /// </summary>
        /// <returns>Horas Trabajadas</returns>
        public static int LeerHoras()
        {
            // VARIABLES
            int horas = 0;
            string aux = null;  // char[] aux;
            bool esValido;

            do
            {
                esValido = true;
                
                // Entrada - Interfaz en Modo Texto
                Console.Write("Introduzca Horas: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    horas = Comprobaciones.ValidarHoras(aux);
                }
                catch (Exception error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine("ERROR: " + error.Message);
                }

            } while (!esValido);

            // SALIDA - Método
            return horas;
        }

        /// <summary>
        /// Captación del Salario por Hora del Trabajador - Interfaz Modo Texto
        /// </summary>
        /// <returns>Salario por Hora</returns>
        public static float LeerSalarioHora()
        {
            float salario = 0f;
            string aux = "";    // Inicialización a la cadena vacía
            bool esValido;      // Control de detección de errores

            do
            {
                esValido = true;    // Inicialización del centinela

                // Entrada - Interfaz en modo texto
                Console.Write("Introduzca el salario por hora: ");
                aux = Console.ReadLine();

                try
                {
                    // Procesamiento - Validación del dato de entrada
                    salario = Comprobaciones.ValidarSalarioHora(aux);
                }
                catch (Exception error)
                {
                    esValido = false;   // Detección del error
                    // Retroalimentación - Interfaz modo texto
                    Console.WriteLine($"ERROR: {error.Message}");
                }

            } while (!esValido);

            return salario;
        }

        /// <summary>
        /// Captación de Datos en formato cadena
        /// </summary>
        /// <param name="entrada">Tipo de dato</param>
        /// <returns>Cadena de caracteres</returns>
        public static string LeerDato(string entrada)
        {
            string cadena = "";

            Console.Write($"Introduzca {entrada}: ");
            cadena = Console.ReadLine();

            return cadena;
        }
        #endregion

        #region MÉTODOS DE SALIDA DE DATOS

        /// <summary>
        /// Muestra una línea de asteriscos
        /// </summary>
        public static void MostrarLinea()
        {
            Console.WriteLine("***********************************************************************");
        }

        /// <summary>
        /// Muestra los datos del empleado
        /// </summary>
        /// <param name="name">Nombre del Empleado</param>
        /// <param name="surname">Apellidos del Empleado</param>
        /// <param name="job">Puesto de Trabajo</param>
        public static void MostrarEmpleado(string name, string surname, string job)
        {
            Console.WriteLine($"Puesto:\t{job}");
            Console.WriteLine($"Nombre:\t{name}\tApellidos:\t{surname}");
        }

        /// <summary>
        /// Muestra los datos del trabajo realizado en la semana por el empleado
        /// </summary>
        /// <param name="horasT">Horas Trabajadas</param>
        /// <param name="horasE">Horas Extra</param>
        /// <param name="salarioH">Salario por Hora de Trabajo</param>
        public static void MostrarDatosSemana(int horasT, int horasE, float salarioH)
        {
            Console.WriteLine($"\tHoras Trabajadas:\t{horasT} Horas\tHoras Extra:\t{horasE} Horas");
            Console.WriteLine($"\tPrecio por Hora:\t{salarioH} Euros/Hora");
        }

        /// <summary>
        /// Muestra los Honorarios del Empleado
        /// </summary>
        /// <param name="sBase">Salario Base</param>
        /// <param name="sExtra">Salario Extra</param>
        public static void MostrarHonorarios(float sBase, float sExtra)
        {
            Console.WriteLine($"\tSalario Base:\t{sBase} Euros\tSalario Extra:\t{sExtra} Euros");
        }

        /// <summary>
        /// Muestra la Nómina del Empleado
        /// </summary>
        /// <param name="sBruto">Salario Bruto</param>
        /// <param name="tasas">Impuestos</param>
        /// <param name="sNeto">Salario Neto</param>
        public static void MostrarNomina(float sBruto, float tasas, float sNeto)
        {
            Console.WriteLine($"\tSalario Bruto:\t{sBruto} Euros");
            Console.WriteLine($"\tImpuestos:\t{tasas} Euros");
            Console.WriteLine($"\tSalario Neto:\t{sNeto}  Euros");
        }

        #endregion
    }
}
