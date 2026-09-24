namespace Sistema_de_alumnos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Persona> comunidad = new List<Persona>();

            comunidad.Add(new Alumno("Ana Perez", 1234));
            comunidad.Add(new Profesor("Marta Diaz", 5678, "Programacion"));
            comunidad.Add(new Preceptor("Carlos Gomez", 9012));

            foreach (Persona persona in comunidad)
            {
                Console.WriteLine(persona.Presentarse());
            }

            Console.ReadLine();
        }
    }
}
