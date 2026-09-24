using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_alumnos
{
    public class Alumno : Persona, IExportable
    {
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }

        public Alumno(string nombre, int documento) : base(nombre, documento)
        {
        }

        public bool CargarNotas(double nota1, double nota2)
        {
            if (nota1 >= 0 && nota1 <= 10 && nota2 >= 0 && nota2 <= 10)
            {
                Nota1 = nota1;
                Nota2 = nota2;
                return true;
            }
            return false;
        }

        public double Promedio()
        {
            return (Nota1 + Nota2) / 2;
        }

        public bool EstaAprobado()
        {
            return Promedio() >= 6;
        }

        public void SubirNota()
        {
            Nota1 += 1;
            if (Nota1 > 10)
            {
                Nota1 = 10;
            }

            Nota2 += 1;
            if (Nota2 > 10)
            {
                Nota2 = 10;
            }
        }

        public override string ToString()
        {
            return $"{Documento} - {Nombre} (promedio: {Promedio()})";
        }

        public override string Presentarse()
        {
            return $"Hola, soy {Nombre}, alumno con legajo {Documento}.";
        }

        public string ExportarLinea()
        {
            return $"ALUMNO;{Documento};{Nombre};{Promedio()}";
        }
    }
}