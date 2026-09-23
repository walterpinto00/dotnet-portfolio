using System;

class Persona
{
    protected string nombre;
    protected int edad;

    public Persona(string nom, int ed)
    {
        nombre = nom;
        edad = ed;
        Console.WriteLine("Constructor Persona");
    }
}

class Estudiante : Persona
{
    protected string codigo;
    protected string programa;

    public Estudiante(string nom, int ed, string cod, string prog)
        : base(nom, ed)  // Llama al constructor de Persona
    {
        codigo = cod;
        programa = prog;
        Console.WriteLine("Constructor Estudiante");
    }
}

class AprendizSENA : Estudiante
{
    private string ficha;

    public AprendizSENA(string nom, int ed, string cod,
                          string prog, string fich)
        : base(nom, ed, cod, prog)  // Llama al constructor de Estudiante
    {
        ficha = fich;
        Console.WriteLine("Constructor AprendizSENA");
    }

    public void MostrarInfo()
    {
        Console.WriteLine("\n=== INFORMACIÓN ===");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Programa: {programa}");
        Console.WriteLine($"Ficha: {ficha}");
    }
}

class Programa
{
    static void Main()
    {
        Console.WriteLine("Creando aprendiz...\n");

        AprendizSENA aprendiz = new AprendizSENA(
            "Carlos",
            22,
            "2024001",
            "ADS",
            "2893847"
        );

        aprendiz.MostrarInfo();
    }
}