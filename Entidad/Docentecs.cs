using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public class Docentecs:Persona
    {
        public double valorhora { get; set; }

        public int horasdictadas { get; set; }

        public double bonificacion { get; set; }

        public double sueldo { get; set; }

        public override void calcularSueldo()
        {



            sueldo = (valorhora * horasdictadas) + bonificacion;



        }

    }
}
