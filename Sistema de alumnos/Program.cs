namespace Sistema_de_alumnos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Julián Capdevila", 123456);

            bool seCargaronMal = alumno1.CargarNotas(47.0, 8.5);
            if (seCargaronMal)
            {
                Console.WriteLine("Notas cargadas con exito.");
            }
            else
            {
                Console.WriteLine("Error: Las notas de Julián son invalidas (deben ser entre 0 y 10).");
            }

            bool seCargaronBien = alumno1.CargarNotas(8.50, 10.00);
            if (seCargaronBien)
            {
                Console.WriteLine("Notas de Julián cargadas con exito.");
            }
            else
            {
                Console.WriteLine("Error: Las notas son invalidas.");
            }

            Console.WriteLine(alumno1);
            Console.ReadLine();
        }
    }
}
