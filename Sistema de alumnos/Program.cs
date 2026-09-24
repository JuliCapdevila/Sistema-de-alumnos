namespace Sistema_de_alumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Julián Capdevila", 123456, 8.50, 10.00);
            Alumno alumno2 = new Alumno("Pablo Perez", 78910, 7.00, 9.50);

            Console.WriteLine("--- Datos Originales ---");
            Console.WriteLine($"Alumno 1: {alumno1.Nombre}, Legajo: {alumno1.Legajo}");
            Console.WriteLine($"Alumno 2: {alumno2.Nombre}, Legajo: {alumno2.Legajo}");

            Console.ReadLine();

            //alumno alumno3 = new alumno();
            //error: no se ha dado ningún argumento que corresponda al parámetro requerido "nombre" de "alumno.alumno(string, int, double, double)"
            //este error me salta porque al principio c# me daba un constructor vacio por defecto lo que me permitia crear el objeto simplemente poniendo new alumno(), como ahora cree un constructor especifico que pide los cuatro datos (nombre, legajo, nota1 y nota2) c# elimino automaticamente el constructor vacio que venia de fabrica, entonces cundo intento instanciar la clase sin pasarle nada entre los parentesis el compilador me frena y me avisa que me falta darle el primer dato obligatorio que es el "nombre".
        }
    }
}
