namespace GNominasV3_ProtecciónDatos
{
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
            // Método para captar el nombre del empleado
            //nominaEmpleado.nombre = "Alex";

            /* Podría asignarle otra clase por ejemplo: */
            nominaEmpleado.nombre = Interfaz.Leerdatos("nombre");
            nominaEmpleado.apellidos = Interfaz.Leerdatos("apellidos");
            nominaEmpleado.puesto = Interfaz.Leerdatos("puesto");

            // Captación de las horas trabajadas
            nominaEmpleado.horasTrabajadas = Interfaz.LeerHoras("horas trabajadas");
            nominaEmpleado.salarioHora = Interfaz.LeerSalarioHora("salario x hora");

            // PROCESO
            // Cálculo de las horas extra que ha echado
            nominaEmpleado.horasExtra = CalculosNomina.CalcularHorExtra(nominaEmpleado.horasTrabajadas);

            // Cálculo del salario base sin tener en cuenta las horas extra
            nominaEmpleado.salarioBase = CalculosNomina.CalculoSalario(nominaEmpleado.horasTrabajadas, nominaEmpleado.salarioHora);

            // Cálculo del salario de las horas extra
            nominaEmpleado.salarioExtra = CalculosNomina.CalculoSalarioExtra(nominaEmpleado.horasExtra, nominaEmpleado.salarioHora);

            // Cálculo del salario bruto (sin impuestos)
            nominaEmpleado.salarioBruto = CalculosNomina.CalculoSalarioBruto(nominaEmpleado.salarioBase, nominaEmpleado.salarioExtra);

            // Cálculo de los impuestos
            nominaEmpleado.impuestos = CalculosNomina.CalculoImpuestos(nominaEmpleado.salarioBruto);

            // Cálculo dle salario Neto
            nominaEmpleado.salrioNeto = CalculosNomina.CalculoSalarioNeto(nominaEmpleado.salarioBruto, nominaEmpleado.impuestos);
            Console.Clear();

            // SALIDA
            Interfaz.LineaDecorativa();

            // Mostrar la Nómina por la consola 
            Interfaz.MostrarNomina(nominaEmpleado);
        }
    }
}