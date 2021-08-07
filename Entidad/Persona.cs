using System;
using System.Collections.Generic;
using System.Text;

namespace Entidad
{
    public abstract class Persona
    {
        public string id { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string edad { get; set; }

        public abstract void calcularSueldo();
        


        public abstract string escribir()
        {

            return $"{id};{nombre};{apellido};{edad}";
        }


    }
}
