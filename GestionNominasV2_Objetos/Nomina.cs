using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNominasV3_ProtecciónDatos
{
    public class Nomina
    {
        // MIEMBROS - CAMPOS - ATRIBUTOS (Son Sinónimos)
        /* Cuando definimos los miembros dentro de una clase, 
         * siempre son privados por defecto.
         * Para hacerlo público se pone el termino "public" delante.*/

        public string? nombre;
        public string? apellidos;
        public string? puesto;

        public int horasTrabajadas;
        public float salarioHora;

        public int horasExtra;
        public float salarioBase;
        public float salarioExtra;
        public float salarioBruto;
        public float impuestos;
        public float salrioNeto;

    }
}
