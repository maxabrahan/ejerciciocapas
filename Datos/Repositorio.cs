using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Datos
{
    public class Repositorio
    {

        string ruta = "categorias.txt";

        public void GuardarPersona(Persona persona)
        {
            FileStream archivo = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(archivo);

            escritor.WriteLine(persona.escribir());

            escritor.Close();
            archivo.Close();


        }
    }

}
