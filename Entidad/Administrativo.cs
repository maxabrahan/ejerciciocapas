using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Administrativo:Persona
    {

        public double salariobasico { get; set; }

        public int hextras { get; set; }

        public int diastrabajados { get; set; }

        public double aportes { get; set; }
        public double sueldo { get; set; }

      
        public override void calcularSueldo()
        {


            sueldo = ((salariobasico / 30) * diastrabajados) + hextras * (salariobasico / 240) * 1.35 - aportes;

        }
    }
}
