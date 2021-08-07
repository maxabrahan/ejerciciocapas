using Datos;
using Entidad;
using System;
using System.Collections.Generic;

using System.Text;

namespace Logica
{
    public class Servicio
    {
        Repositorio repositorio = new Repositorio();

       public string GuardarPersona(Persona persona)
        {

            try
            {
                repositorio.GuardarPersona(persona);

                return $"Datos guardados exitosamente";

            }catch(Exception e)
            {

                return $"se presento el siguiente error: {e.Message}";
            }
        }
    }


    }


