using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GNominasV3_ProtecciónDatos
{
    /// <summary>
    /// Objetivo V3: Dotar de Protección y Seguridad a la Clase
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTES

            // RECURSOS
            // Defino que recursos voy a utilizar
            /* Ahora mismo nominaEmpleado (que sería el objeto)
             * vale NULL porque aun no se le ha asignado memoria */
            Nomina nominaEmpleado;

            // INICIALIZACIÓN
            // Se le asigna una porción de memoria pero ahora mismo no tiene nada.
            nominaEmpleado = new Nomina();

            // ENTRADA
            // Método para captar el nombre del empleado dándole un valor directamente
            //nominaEmpleado.nombre = "Alex";

            /* Podría asignarle otra clase por ejemplo: */
            nominaEmpleado.nombre = Interfaz.Leerdatos("nombre");
            nominaEmpleado.apellidos = Interfaz.Leerdatos("apellidos");
            nominaEmpleado.puesto = Interfaz.Leerdatos("puesto");

            // Captación de las horas trabajadas
            Interfaz.LeerHoras("horas trabajadas", nominaEmpleado);

            // Captación del salario por hora del trabajador
            Interfaz.LeerSalarioHora("salario x hora",nominaEmpleado);

            //nominaEmpleado.salarioHora = Interfaz.LeerSalarioHora("salario x hora");

            // PROCESO
            // Cálculo de las horas extra que ha echado
            //nominaEmpleado.HorasExtra = CalculosNomina.CalcularHorExtra
            //    (nominaEmpleado.HorasTrabajadas);


            // Cálculo del salario base sin tener en cuenta las horas extra
            //nominaEmpleado.salarioBase = CalculosNomina.CalculoSalario
            //    (nominaEmpleado.HorasTrabajadas, nominaEmpleado.SalarioHora);


            // Cálculo del salario de las horas extra
            //nominaEmpleado.salarioExtra = CalculosNomina.CalculoSalarioExtra
            //    (nominaEmpleado.HorasExtra, nominaEmpleado.SalarioHora);


            // Cálculo del salario bruto (sin impuestos)
            //nominaEmpleado.salarioBruto = CalculosNomina.CalculoSalarioBruto
            //    (nominaEmpleado.SalarioBase, nominaEmpleado.SalarioExtra);

            // Cálculo de los impuestos
            //nominaEmpleado.impuestos = CalculosNomina.CalculoImpuestos
            //    (nominaEmpleado.salarioBruto);

            // Cálculo dle salario Neto
            //nominaEmpleado.salrioNeto = CalculosNomina.CalculoSalarioNeto
            //    (nominaEmpleado.salarioBruto, nominaEmpleado.impuestos);
            Console.Clear();

            // SALIDA
            //Interfaz.LineaDecorativa();

            // Mostrar la Nómina por la consola 
            //Interfaz.MostrarNomina(nominaEmpleado);
            Console.Clear();

            Interfaz.MostrarEmpleado(nominaEmpleado.nombre, 
                nominaEmpleado.apellidos, nominaEmpleado.puesto);
            Interfaz.MostrarLinea();
            Interfaz.MostrarDatosSemana(nominaEmpleado.HorasTrabajadas, 
                nominaEmpleado.HorasExtra, nominaEmpleado.SalarioHora);
            Interfaz.MostrarLinea();
            Interfaz.MostrarHonorarios(nominaEmpleado.SalarioBase, nominaEmpleado.SalarioExtra);
            Interfaz.MostrarLinea();
            //Interfaz.MostrarNomina(salarioBruto, impuestos, salarioNeto);

        }
    }
}