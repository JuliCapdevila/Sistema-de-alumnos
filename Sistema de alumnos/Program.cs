using System;
using System.Collections.Generic;

namespace Sistema_de_alumnos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Materia materia1 = new Materia("PROG1", "Programación I", 128);
            Materia materia2 = new Materia("BD1", "Bases de Datos", 80);

            Alumno alumno1 = new Alumno("Ana Pérez", 1234);
            alumno1.CargarNotas(6.0, 8.0);

            Profesor profesor1 = new Profesor("Marta Díaz", 5678, "Programación");

            List<IExportable> listaExportable = new List<IExportable>();
            listaExportable.Add(alumno1);
            listaExportable.Add(profesor1);
            listaExportable.Add(materia1);
            listaExportable.Add(materia2);

            foreach (IExportable elemento in listaExportable)
            {
                Console.WriteLine(elemento.ExportarLinea());
            }

            Console.ReadLine();
        }
    }
}
