using System.Collections.Generic;

namespace SistemaGestionAprendices
{
    internal class Aprendiz
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Nota { get; set; }

        public void MostrarInfo()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Edad: {Edad} años");
            Console.WriteLine($"Nota: {Nota:F2}");
            Console.WriteLine(Nota >= 3.0 ? "Estado: APROBADO" : "Estado: REPROBADO");
        }
    }

    internal class Program
    {
        static List<Aprendiz> aprendices = new List<Aprendiz>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("======================================");
                Console.WriteLine("  SISTEMA DE GESTIÓN DE APRENDICES");
                Console.WriteLine("  Walter Pinto - SENA CSET Bucaramanga");
                Console.WriteLine("======================================");
                Console.WriteLine();
                Console.WriteLine("1. Agregar aprendiz");
                Console.WriteLine("2. Listar aprendices");
                Console.WriteLine("3. Buscar aprendiz");
                Console.WriteLine("4. Actualizar aprendiz");
                Console.WriteLine("5. Eliminar aprendiz");
                Console.WriteLine("6. Salir");
                Console.WriteLine();
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": AgregarAprendiz(); break;
                    case "2": ListarAprendices(); break;
                    case "3": BuscarAprendiz(); break;
                    case "4": ActualizarAprendiz(); break;
                    case "5": EliminarAprendiz(); break;
                    case "6": continuar = false; Console.WriteLine("\n¡Hasta luego!"); break;
                    default: Console.WriteLine("\nOpción no válida"); Console.ReadKey(); break;
                }
            }
        }

        static void AgregarAprendiz()
        {
            Console.WriteLine("\n=== AGREGAR APRENDIZ ===");
            try
            {
                Console.Write("Código: ");
                string codigo = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(codigo))
                {
                    Console.WriteLine("El código no puede quedar vacío");
                    Console.ReadKey();
                    return;
                }

                foreach (var aprendiz in aprendices)
                {
                    if (aprendiz.Codigo == codigo)
                    {
                        Console.WriteLine("Ya existe un aprendiz con ese código");
                        Console.ReadKey();
                        return;
                    }
                }

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad < 0 || edad > 100)
                {
                    Console.WriteLine("La edad debe estar entre 0 y 100");
                    Console.ReadKey();
                    return;
                }

                Console.Write("Nota: ");
                double nota = double.Parse(Console.ReadLine());

                if (nota < 0.0 || nota > 5.0)
                {
                    Console.WriteLine("La nota debe estar entre 0.0 y 5.0");
                    Console.ReadKey();
                    return;
                }

                aprendices.Add(new Aprendiz { Codigo = codigo, Nombre = nombre, Edad = edad, Nota = nota });
                Console.WriteLine("\nAprendiz agregado con éxito");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: ingrese valores numéricos válidos");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarAprendices()
        {
            Console.WriteLine("\n=== LISTA DE APRENDICES ===");
            if (aprendices.Count == 0)
            {
                Console.WriteLine("Aún no hay aprendices registrados");
            }
            else
            {
                foreach (var aprendiz in aprendices)
                {
                    Console.WriteLine("-----------------------------");
                    aprendiz.MostrarInfo();
                }
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"Total: {aprendices.Count} aprendiz(ces)");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void BuscarAprendiz()
        {
            Console.WriteLine("\n=== BUSCAR APRENDIZ ===");
            Console.Write("Código a buscar: ");
            string codigo = Console.ReadLine();
            bool encontrado = false;

            foreach (var aprendiz in aprendices)
            {
                if (aprendiz.Codigo == codigo)
                {
                    Console.WriteLine("\n=== APRENDIZ ENCONTRADO ===");
                    aprendiz.MostrarInfo();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado) Console.WriteLine("\nNo se encontró ese aprendiz");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void ActualizarAprendiz()
        {
            Console.WriteLine("\n=== ACTUALIZAR APRENDIZ ===");
            Console.Write("Código: ");
            string codigo = Console.ReadLine();
            bool encontrado = false;

            foreach (var aprendiz in aprendices)
            {
                if (aprendiz.Codigo == codigo)
                {
                    Console.WriteLine("\n=== DATOS ACTUALES ===");
                    aprendiz.MostrarInfo();

                    // nota: aqui no se vuelve a validar el rango, quedo pendiente
                    Console.Write("\nNuevo nombre (Enter para no cambiar): ");
                    string nombre = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nombre)) aprendiz.Nombre = nombre;

                    Console.Write("Nueva edad (Enter para no cambiar): ");
                    string edad = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(edad)) aprendiz.Edad = int.Parse(edad);

                    Console.Write("Nueva nota (Enter para no cambiar): ");
                    string nota = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(nota)) aprendiz.Nota = double.Parse(nota);

                    Console.WriteLine("\nAprendiz actualizado");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado) Console.WriteLine("\nNo se encontró ese aprendiz");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void EliminarAprendiz()
        {
            Console.WriteLine("\n=== ELIMINAR APRENDIZ ===");
            Console.Write("Código: ");
            string codigo = Console.ReadLine();
            bool encontrado = false;

            foreach (var aprendiz in aprendices)
            {
                if (aprendiz.Codigo == codigo)
                {
                    Console.WriteLine("\n=== DATOS ===");
                    aprendiz.MostrarInfo();
                    Console.Write("\n¿Eliminar este aprendiz? (S/N): ");
                    if (Console.ReadLine().ToUpper() == "S")
                    {
                        aprendices.Remove(aprendiz);
                        Console.WriteLine("\nAprendiz eliminado");
                    }
                    else
                    {
                        Console.WriteLine("\nOperación cancelada");
                    }
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado) Console.WriteLine("\nNo se encontró ese aprendiz");
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
