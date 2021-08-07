using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Contratista:Persona
    {
        public double valormensual { get; set; }

        public int diastrabajados { get; set; }

        public double valordescontado { get; set; }

        public double sueldo { get; set; }

        public override void calcularSueldo()
        {



            sueldo = ((valormensual / 30) * diastrabajados) - valordescontado;

        }
    }
}
