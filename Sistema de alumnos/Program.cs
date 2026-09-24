namespace Sistema_de_alumnos
{
    namespace Sistema_de_alumnos
    {
        public class Program
        {
            public static void Main(string[] args)
            {
                List<Alumno> alumnos = new List<Alumno>();
                bool salir = false;

                while (!salir)
                {
                    Console.WriteLine("\n--- MENU ---");
                    Console.WriteLine("1. Agregar un alumno");
                    Console.WriteLine("2. Listar todos los alumnos");
                    Console.WriteLine("3. Buscar un alumno por documento");
                    Console.WriteLine("4. Mostrar el promedio general del curso");
                    Console.WriteLine("5. Mostrar cuantos alumnos estan aprobados");
                    Console.WriteLine("6. Salir");
                    Console.Write("Elija una opcion: ");

                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Documento: ");
                            int documento = int.Parse(Console.ReadLine());

                            Alumno nuevoAlumno = new Alumno(nombre, documento);

                            Console.Write("Nota 1: ");
                            double nota1 = double.Parse(Console.ReadLine());
                            Console.Write("Nota 2: ");
                            double nota2 = double.Parse(Console.ReadLine());

                            if (nuevoAlumno.CargarNotas(nota1, nota2))
                            {
                                alumnos.Add(nuevoAlumno);
                                Console.WriteLine("Alumno agregado con exito.");
                            }
                            else
                            {
                                Console.WriteLine("Error: Las notas deben estar entre 0 y 10. No se agrego el alumno.");
                            }
                            break;

                        case "2":
                            if (alumnos.Count == 0)
                            {
                                Console.WriteLine("No hay alumnos cargados.");
                            }
                            else
                            {
                                foreach (Alumno a in alumnos)
                                {
                                    Console.WriteLine(a);
                                }
                            }
                            break;

                        case "3":
                            Console.Write("Ingrese el documento a buscar: ");
                            int documentoBuscado = int.Parse(Console.ReadLine());
                            bool encontrado = false;

                            foreach (Alumno a in alumnos)
                            {
                                if (a.Documento == documentoBuscado)
                                {
                                    Console.WriteLine(a);
                                    encontrado = true;
                                    break;
                                }
                            }

                            if (!encontrado)
                            {
                                Console.WriteLine("El alumno no existe.");
                            }
                            break;

                        case "4":
                            if (alumnos.Count == 0)
                            {
                                Console.WriteLine("El promedio general es 0 (no hay alumnos).");
                            }
                            else
                            {
                                double sumaPromedios = 0;
                                foreach (Alumno a in alumnos)
                                {
                                    sumaPromedios += a.Promedio();
                                }
                                double promedioGeneral = sumaPromedios / alumnos.Count;
                                Console.WriteLine($"El promedio general del curso es: {promedioGeneral}");
                            }
                            break;

                        case "5":
                            int aprobados = 0;
                            foreach (Alumno a in alumnos)
                            {
                                if (a.EstaAprobado())
                                {
                                    aprobados++;
                                }
                            }
                            Console.WriteLine($"Cantidad de alumnos aprobados: {aprobados}");
                            break;

                        case "6":
                            salir = true;
                            break;

                        default:
                            Console.WriteLine("Opcion inexistente. Intente de nuevo.");
                            break;
                    }
                }
            }
        }
    }
}
