using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Polimorfismo
{
    public class EmpleadoAdministrativo : Empleado, IEmpleado
    {
        private decimal SueldoMensual;
        private bool AlcanzoMeta;

        public EmpleadoAdministrativo(string Nombre, string Apellido, string Cedula, decimal SueldoMensual, bool AlcanzoMeta)
            : base(Nombre, Apellido, Cedula)
        {
            this.SueldoMensual = SueldoMensual;
            this.AlcanzoMeta = AlcanzoMeta;
        }

        public decimal sueldoMensual
        {
            get => SueldoMensual;
            set
            {
                if (value >= 0)
                {
                    SueldoMensual = value;
                }
                else
                {
                    throw new ArgumentException("El sueldo no puede ser negativo.");
                }
            }
        }

        public bool alcanzoMeta
        {
            get => AlcanzoMeta;
            set => AlcanzoMeta = value;
        }

        public override decimal Ingresos()
        {
            return AlcanzoMeta ? SueldoMensual : SueldoMensual / 2;
        }
    }
}
