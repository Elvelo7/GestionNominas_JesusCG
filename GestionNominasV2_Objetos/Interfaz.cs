using System;
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
            Console.WriteLine($"\tHoras Trabajadas: {nomEmplead.horasTrabajadas}");
            Console.WriteLine($"\tSalario x Hora: {nomEmplead.salarioHora}");
            Console.WriteLine($"\tHoras Extra: {nomEmplead.horasExtra}");
            Console.WriteLine($"\tSalario Base: {nomEmplead.salarioBase}");
            Console.WriteLine($"\tSalario Extra: {nomEmplead.salarioExtra}");
            Console.WriteLine($"\tSalario Bruto: {nomEmplead.salarioBruto}");
            LineaDecorativa();
            Console.WriteLine($"\tImpuestos: {nomEmplead.impuestos}");
            Console.WriteLine($"\tSalario Neto: {nomEmplead.salrioNeto}");
            LineaDecorativa();

        }


        /// <summary>
        /// Leer Horas trabajadas
        /// </summary>
        /// <param name="horas"></param>
        /// <returns></returns>
        public static int LeerHoras(string horas)
        {
            // VARIABLES
            int valorDevuelto = 0;
            string aux = null;  // char[] aux;  Es lo mismo que poner string aux = "";
            bool esValido;

            do
            {
                esValido = true;

                // Entrada - Interfaz en Modo Texto
                Console.Write($"Introduzca {horas}: ");
                aux = Console.ReadLine();

                try
                {
                    // Proceso de Validación
                    valorDevuelto = Comprobaciones.ValidarHoras(aux);
                }
                catch (Exception error)
                {
                    // SALIDA - Retroalimentación de Errores
                    esValido = false;   // Actualización del detector de errores
                    Console.WriteLine("ERROR: " + error.Message);
                }

            } while (!esValido);

            // SALIDA - Método
            return valorDevuelto;
        }

        /// <summary>
        /// Leer Salario x Hora
        /// </summary>
        /// <param name="salarioHora"></param>
        /// <returns></returns>
        public static float LeerSalarioHora(string salarioHora)
        {
            float salario = 0f;
            string aux = "";    // Inicialización a la cadena vacía
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

        public static void LineaDecorativa()
        {
            Console.WriteLine("*******************************************");
            
        }
    }
}
