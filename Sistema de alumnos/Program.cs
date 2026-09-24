namespace Sistema_de_alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();

            alumno1.nombre = "Julián";
            alumno1.legajo = 12345;
            alumno1.nota1 = 8.00;
            alumno1.nota2 = 10.00;

            Alumno alumno2 = new Alumno();
            alumno2.nombre = "Pablo";
            alumno2.legajo = 678910;
            alumno2.nota1 = 7.50;
            alumno2.nota2 = 8.75;


            Console.WriteLine($"Nombre: {alumno1.nombre}, Legajo = {alumno1.legajo}");
            Console.WriteLine($"Nombre: {alumno2.nombre}, Legajo = {alumno2.legajo}");


        }
    }
}
