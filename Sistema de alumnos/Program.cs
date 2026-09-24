namespace Sistema_de_alumnos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Julián Capdevila", 123456, 8.50, 10.00);
            Alumno alumno2 = new Alumno("Pablo Perez", 78910, 7.00, 9.50);

            Console.WriteLine(alumno1);
            Console.WriteLine(alumno2);

            Console.ReadLine();
        }
    }
}
