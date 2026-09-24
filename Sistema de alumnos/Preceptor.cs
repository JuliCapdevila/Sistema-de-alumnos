using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    public class Preceptor : Persona
    {
        public Preceptor(string nombre, int documento) : base(nombre, documento)
        {
        }

        public override string Presentarse()
        {
            return $"Hola, soy {Nombre} y soy preceptor.";
        }
    }
}
