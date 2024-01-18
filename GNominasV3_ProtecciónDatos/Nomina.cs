using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GNominasV3_ProtecciónDatos
{
    public class Nomina
    {
        // CONSTANTES
        // const int LIMITE_HORAS = 60;  --> Es privado por defecto
        private const int LIMITE_HORAS = 60;  // Lo pongo así para enterarme mejor al principio

        // Para el salario del trabajador
        private const float SALARIO_MAX = 22.5f;
        private const float SALARIO_MIN = 1.0f;

        // Constante para el calculo de las horas extra
        const int HORAS_SEMANALES = 35;         // NO pongo privado porque es privado de serie

        // Constante para el calculo del salario extra
        const float INCR_EXTRA = 1.5f;

        // MIEMBROS - CAMPOS - ATRIBUTOS (Son Sinónimos)
        /* Cuando definimos los miembros dentro de una clase, 
         * siempre son privados por defecto.
         * Para hacerlo público se pone el termino "public" delante.*/

        public string? nombre;
        public string? apellidos;
        public string? puesto;

        private int _horasTrabajadas;
        private float _salarioHora;

        private int _horasExtra;    // Protección: NO permitir establecer ningún valor externo
        private float _salarioBase;
        private float _salarioExtra;
        public float salarioBruto;
        public float impuestos;
        public float salrioNeto;

        // PROPIEDADES
        /// <summary>
        /// 
        /// </summary>
        public int HorasTrabajadas
        {
            get    /* Se activa cuando se consulta el valor del miembro, es decir:
                    * Resultado = -----.HorasTrabajadas - 10; */
            {
                if (_salarioHora == 0) throw new Exception("Horas trabajadas no establecidas");
                return _horasTrabajadas;
            }
            set    /* Se activa cuando se le asigna a la propiedad un valor 
                    * Ejemplo: ----.HorasTrabajadas = 34; */
            {
                // Comprobación 1: Horas no superiores al límite
                if (value > LIMITE_HORAS) throw new Exception($"Las horas son superiores a " +
                    $"{LIMITE_HORAS} horas");

                // Comprobación 2: Horas inferiores o iguales a 0
                if (value <= 0) throw new Exception($"Horas inferiores o iguales a 0");

                _horasTrabajadas = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public float SalarioHora
        {
            get
            {
                if(_salarioHora == 0) throw new Exception("Salario x Hora no establecido");
                return _salarioHora;
            }
            set
            {
                // Comprobación salario superior al mínimo
                if (value < SALARIO_MIN) throw new Exception
                        ($"Valor inferior a {SALARIO_MIN} Euros");

                // Comprobación salario superior al máximo
                if (value > SALARIO_MAX) throw new Exception
                        ($"Valor superior a {SALARIO_MAX} Euros");

                _salarioHora = value;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        public int HorasExtra           // No tiene el SET porque es una propiedad de solo lectura
        {
            get
            {
                CalcularHorasExtra();     // Llamamos a los métodos antes de que lo devuelva
                                          // para que haga la operación antes y poder poner 
                                          // privado el método CalcularHorasExtra()
                return _horasExtra;
            }
        }

        // MÉTODOS PÚBLICOS

        /// <summary>
        /// 
        /// </summary>
        private void CalcularHorasExtra()    // Objetivo: Actualizar las horas extra
        {
            // RECURSOS LOCALES
            // V1: Sin Protección
            //if (_horasTrabajadas > HORAS_SEMANALES) _horasExtra = _horasTrabajadas - HORAS_SEMANALES;
            //else _horasExtra = 0;

            // V2: Con Protección utilizando la Propiedad en vez del MieMbro, para que sea la propiedad la que lo gestione
            if (HorasTrabajadas > HORAS_SEMANALES) _horasExtra = HorasTrabajadas - HORAS_SEMANALES;
            else _horasExtra = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        public float SalarioBase
        {
            get
            {
                CalcularSalarioBase();
                return _salarioBase;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalcularSalarioBase()
        {
            if(HorasTrabajadas > HORAS_SEMANALES) _salarioBase = HORAS_SEMANALES * SalarioHora;
            else _salarioBase = HorasTrabajadas * SalarioHora;
        }

        public float SalarioExtra
        {
            get
            {
                CalcularSalarioExtra();
               return _salarioExtra;
            }
        }

        private void CalcularSalarioExtra()
        {
            _salarioExtra = HorasExtra * SalarioHora * INCR_EXTRA;
            Math.Round(_salarioExtra, 2);
        }
    }
}
