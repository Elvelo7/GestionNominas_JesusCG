﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNominasV3_ProtecciónDatos
{
    internal class Interfaz
    {
        /// <summary>
        /// Leer Datos Usuario
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Nombre, apellidos y puesto</returns>
        public static string? Leerdatos(string dato)
        {

            // Colocando el ´?´ delante hacemos que pueda ser nulo
            string? cadena = null;

            Console.Write($"Introduzca {dato}: ");
            cadena = Console.ReadLine();

            return cadena;
        }
        /// <summary>
        /// Mostrar la Nómina
        /// </summary>
        /// <param name="nomEmplead"></param>
        public static void MostrarNomina(Nomina nomEmplead)
        {
            Console.WriteLine($"\tNombre: {nomEmplead.nombre}");
            Console.WriteLine($"\tApellidos: {nomEmplead.apellidos}");
            Console.WriteLine($"\tPuesto: {nomEmplead.puesto}");
            LineaDecorativa();
            Console.WriteLine($"\tHoras Trabajadas: {nomEmplead.HorasTrabajadas}");
            Console.WriteLine($"\tSalario x Hora: {nomEmplead.SalarioHora}");
            Console.WriteLine($"\tHoras Extra: {nomEmplead.HorasExtra}");
            Console.WriteLine($"\tSalario Base: {nomEmplead.SalarioBase}");
            Console.WriteLine($"\tSalario Extra: {nomEmplead.SalarioExtra}");
            Console.WriteLine($"\tSalario Bruto: {nomEmplead.SalarioBruto}");
            LineaDecorativa();
            Console.WriteLine($"\tImpuestos: {nomEmplead.Impuestos}");
            Console.WriteLine($"\tSalario Neto: {nomEmplead.SalarioNeto}");
            LineaDecorativa();

        }

        /// <summary>
        /// Leer Horas trabajadas del usuario
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="obj"></param>
        public static void LeerHoras(string texto, Nomina obj)
        {
            // VARIABLES
            string? aux = null;  // char[] aux;  Es lo mismo que poner string aux = "";
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca {texto}: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    obj.HorasTrabajadas = Comprobaciones.ValidarHoras(aux);
                }
                catch (Exception error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine("ERROR: " + error.Message);
                }

            } while (!esValido);

            // SALIDA - Método

        }

        /// <summary>
        /// Leer Salario x Hora
        /// </summary>
        /// <param name="salarioHora"></param>
        /// <returns></returns>
        public static void LeerSalarioHora(string salarioHora, Nomina nominaEmpleado)
        {
            string? aux = "";    // Inicialización a la cadena vacía
            bool esValido;      // Control de detección de errores

            do
            {
                esValido = true;    // Inicialización del centinela

                // Entrada - Interfaz en modo texto
                Console.Write($"Introduzca {salarioHora}: ");
                aux = Console.ReadLine();

                try
                {
                    // Procesamiento - Validación del dato de entrada
                    nominaEmpleado.SalarioHora = Comprobaciones.ValidarSalarioHora(aux);
                }
                catch (Exception error)
                {
                    esValido = false;   // Detección del error
                    // Retroalimentación - Interfaz modo texto
                    Console.WriteLine($"ERROR: {error.Message}");
                }

            } while (!esValido);

        }

        public static void LineaDecorativa()
        {
            Console.WriteLine("*********************************************");
            
        }

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
