using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Polimorfismo
{
    public abstract class DocenteContratoFijo : Empleado, IEmpleado
    {
        private decimal SueldoSem;
        private bool AlcanzoMeta;

        protected DocenteContratoFijo(string Nombre, string Apellido, string Cedula, decimal SueldoSem, bool AlcanzoMeta)
            : base(Nombre, Apellido, Cedula)
        {
            this.SueldoSem = SueldoSem;
            this.AlcanzoMeta = AlcanzoMeta;
        }

        public decimal sueldoSem
        {
            get => SueldoSem;
            set
            {
                if (value >= 0)
                {
                    SueldoSem = value;
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
            return AlcanzoMeta ? SueldoSem : SueldoSem / 2;
        }
    }
}
