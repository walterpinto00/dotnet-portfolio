using System;

// NIVEL 1: Clase Base
class Vehiculo
{
    public string marca;
    public string modelo;
    public int año;

    public void Encender()
    {
        Console.WriteLine("Vehículo encendido");
    }

    public void Apagar()
    {
        Console.WriteLine("Vehículo apagado");
    }
}

// NIVEL 2: Hereda de Vehículo
class Auto : Vehiculo
{
    public int puertas;
    public string color;

    public void AbrirMaletero()
    {
        Console.WriteLine("Maletero abierto");
    }
}

// NIVEL 3: Hereda de Auto (y indirectamente de Vehículo)
class AutoDeportivo : Auto
{
    public int caballosFuerza;

    public void ActivarTurbo()
    {
        Console.WriteLine("¡Turbo activado! 🚀");
    }

    public void MostrarEspecificaciones()
    {
        Console.WriteLine($"{marca} {modelo} ({año})");
        Console.WriteLine($"Color: {color}");
        Console.WriteLine($"Puertas: {puertas}");
        Console.WriteLine($"Caballos de fuerza: {caballosFuerza}");
    }
}

class Programa
{
    static void Main()
    {
        AutoDeportivo deportivo = new AutoDeportivo();

        // Atributos de Vehículo (nivel 1)
        deportivo.marca = "Ferrari";
        deportivo.modelo = "488 GTB";
        deportivo.año = 2023;

        // Atributos de Auto (nivel 2)
        deportivo.puertas = 2;
        deportivo.color = "Rojo";

        // Atributos de AutoDeportivo (nivel 3)
        deportivo.caballosFuerza = 670;

        // Métodos heredados de los 3 niveles
        deportivo.Encender();
        deportivo.AbrirMaletero();
        deportivo.ActivarTurbo();

        Console.WriteLine();
        deportivo.MostrarEspecificaciones();

        deportivo.Apagar();
    }
}