using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Polimorfismo
{
    public abstract class Empleado
    {
        private string Nombre {  get; set; }
        private string Apellido {  get; set; }
        private string Cedula { get; set; }

        public Empleado(string Nombre, string Apellido, string Cedula) 
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Cedula = Cedula;
        }

        public abstract decimal Ingresos();
    }
}
