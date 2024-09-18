using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Polimorfismo
{
    public abstract class DocentePorHora : Empleado, IEmpleado
    {
        private readonly decimal SueldoPorHoras = 800;
        private decimal HorasTrabajadas;

        protected DocentePorHora(string Nombre, string Apellido, string Cedula, decimal HorasTrabajadas)
            : base(Nombre, Apellido, Cedula)
        {
            this.HorasTrabajadas = HorasTrabajadas;
        }

        public decimal horasTrabajadas
        {
            get => HorasTrabajadas;
            set
            {
                if (value > 0)
                {
                    HorasTrabajadas = value;
                }
                else
                {
                    throw new ArgumentException("Las horas trabajadas deben ser mayores que 0.");
                }
            }
        }

        public override decimal Ingresos()
        {
            return SueldoPorHoras * HorasTrabajadas;
        }
    }
}


