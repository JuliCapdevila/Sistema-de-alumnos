namespace Sistema_de_alumnos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Julián Capdevila", 123456, 8.50, 10.00);
            Alumno alumno2 = new Alumno("Pablo Perez", 78910, 7.00, 9.50);

            Console.WriteLine($"Promedio de {alumno1.Nombre}: {alumno1.Promedio()}");
            Console.WriteLine($"Promedio de {alumno2.Nombre}: {alumno2.Promedio()}");

            Console.WriteLine($"Esta aprobado {alumno1.Nombre}: {alumno1.EstaAprobado()}");
            Console.WriteLine($"Esta aprobado {alumno2.Nombre}: {alumno2.EstaAprobado()}");

            alumno1.SubirNota();
            alumno2.SubirNota();

            Console.WriteLine($"Notas actualizadas de {alumno1.Nombre}: {alumno1.Nota1} y {alumno1.Nota2}");
            Console.WriteLine($"Notas actualizadas de {alumno2.Nombre}: {alumno2.Nota1} y {alumno2.Nota2}");

            Console.WriteLine($"Nuevo promedio de {alumno2.Nombre}: {alumno2.Promedio()}");

            Console.ReadLine();
        }
    }
}
