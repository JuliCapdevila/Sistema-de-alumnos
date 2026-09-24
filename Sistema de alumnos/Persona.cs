using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Documento { get; private set; }

        public Persona(string nombre, int documento)
        {
            Nombre = nombre;
            Documento = documento;
        }
    }
}
