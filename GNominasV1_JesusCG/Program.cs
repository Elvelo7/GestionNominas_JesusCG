namespace GNominasV1_JesusCG
{
    internal class Program
    {
        /// <summary>
        /// Controlador Principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // CONSTANTES

            // VARIABLES - RECURSOS
            string nombre, apellidos, puesto;
            int horasTrabajadas = 0;
            float salarioHora = 0.0f;
            int horasExtra = 0;
            float salarioBase = 0.0f;
            float salarioExtra = 0.0f;
            float salarioBruto = 0.0f;
            float impuestos = 0.0f;
            float salarioNeto = 0.0f;

            // ENTRADA
            // Captación de Datos del Trabajador
            nombre = Interfaz.LeerDato("Nombre");
            apellidos = Interfaz.LeerDato("Apellidos");
            puesto = Interfaz.LeerDato("Puesto");
            
            // Captación de las Horas Trabajadas
            horasTrabajadas = Interfaz.LeerHoras();

            // Captación del Salario por Hora percibido
            salarioHora = Interfaz.LeerSalarioHora();

            // PROCESO
            // Cálculo de las Horas Extra
            horasExtra = CalculosNomina.HorasExtra(horasTrabajadas);

            // Cálculo del Salario Base
            salarioBase = CalculosNomina.SalarioBase(horasTrabajadas, salarioHora);

            // Cálculo del Salario Extra
            salarioExtra = CalculosNomina.SalarioExtra(horasExtra, salarioHora);

            // Cálculo del Salario Bruto
            salarioBruto = CalculosNomina.SalarioBruto(salarioBase, salarioExtra);

            // Cálculo de los Impuestos
            impuestos = CalculosNomina.Impuestos(salarioBruto);

            // Cálculo del Salario Neto
            salarioNeto = CalculosNomina.SalarioNeto(salarioBruto, impuestos);

            // SALIDA
            // Se ha determinado subdividir la salida en varios métodos para facilitar la 
            // Legibilidad del código y simplificar el número de parámetros por método
            Interfaz.MostrarEmpleado(nombre, apellidos, puesto);
            Interfaz.MostrarLinea();
            Interfaz.MostrarDatosSemana(horasTrabajadas, horasExtra, salarioHora);
            Interfaz.MostrarLinea();
            Interfaz.MostrarHonorarios(salarioBase, salarioExtra);
            Interfaz.MostrarLinea();
            Interfaz.MostrarNomina(salarioBruto, impuestos, salarioNeto);
        }
    }
}
