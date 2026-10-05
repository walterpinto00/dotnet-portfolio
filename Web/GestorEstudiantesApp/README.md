# ClienteApp - Sistema CRUD de Clientes en N-Capas

## Descripcion
Aplicacion de escritorio desarrollada con **Windows Forms** y **C# .NET 8** que implementa el patron de arquitectura **N-Capas** para gestionar el registro de clientes.

## Arquitectura (N-Capas)
| Capa | Proyecto | Responsabilidad |
|------|----------|-----------------|
| Datos | ClienteApp.Datos | Entidad Cliente y acceso a SQL Server con ADO.NET |
| Negocio | ClienteApp.Negocio | Validaciones y reglas de negocio |
| Presentacion | ClienteApp.UI | Formulario Windows Forms con DataGridView |

## Funcionalidades
- Listar todos los clientes registrados
- Crear nuevo cliente (Nombre, Apellido, Telefono, Email)
- Editar cliente existente seleccionandolo del grid
- Eliminar cliente con confirmacion

## Tecnologias
- C# .NET 8 / Windows Forms
- ADO.NET (SqlConnection, SqlCommand)
- SQL Server (LocalDB o SQLEXPRESS)

## Base de Datos
`sql
CREATE DATABASE ClienteDB;
USE ClienteDB;
CREATE TABLE Clientes (
    Id INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100),
    Telefono NVARCHAR(20),
    Email NVARCHAR(150)
);
`
"@ | Set-Content "C:\Users\walte\Documents\Trabajos del SENA\C# Rodolfo\Escritorio\BASE DE DATOS\Ejercicio01\README.md" -Encoding UTF8

# README VehiculoApp
@"
# VehiculoApp - Gestion de Vehiculos en N-Capas con Entity Framework

## Descripcion
Aplicacion de escritorio en **Windows Forms** que gestiona un catalogo de vehiculos usando **Entity Framework Core** y arquitectura **N-Capas**.

## Arquitectura
| Capa | Proyecto | Responsabilidad |
|------|----------|-----------------|
| Datos | VehiculoApp.Datos | Entidad Vehiculo, DbContext EF Core, Repositorio |
| Negocio | VehiculoApp.Negocio | Servicio de validacion y logica |
| Presentacion | VehiculoApp.UI | Formulario con grid interactivo |

## Funcionalidades
- CRUD completo de vehiculos (Placa, Marca, Modelo, Año, Valor Comercial)
- Validacion de campos obligatorios (Placa y Marca)
- Persistencia con Entity Framework Code-First

## Tecnologias
- C# .NET 8 / Windows Forms
- Entity Framework Core 8 + SQL Server
- Patron Repositorio

## Migraciones
`ash
cd VehiculoApp.Datos
dotnet ef migrations add InitialCreate
dotnet ef database update
`
"@ | Set-Content "C:\Users\walte\Documents\Trabajos del SENA\C# Rodolfo\Escritorio\BASE DE DATOS\Ejercicio02\README.md" -Encoding UTF8

# README FarmaciaApp
@"
# FarmaciaApp - Inventario de Medicamentos con Entity Framework

## Descripcion
Sistema de gestion de inventario para una farmacia, desarrollado con **Windows Forms** y **Entity Framework Core** (Code-First). Permite registrar, editar y eliminar medicamentos con control de stock y fechas de vencimiento.

## Funcionalidades
- Registro de medicamentos con: Nombre, Laboratorio, Presentacion, Stock, Precio Unitario, Fecha de Vencimiento
- Datos de muestra precargados (seed data) con 2 medicamentos de ejemplo
- CRUD completo desde una interfaz grafica intuitiva
- Control visual del inventario mediante DataGridView

## Tecnologias
- C# .NET 8 / Windows Forms
- Entity Framework Core 8 (Code-First con Seed Data)
- SQL Server SQLEXPRESS

## Base de Datos
La base de datos se crea automaticamente con EF Core. Solo necesitas correr:
`ash
dotnet ef migrations add InitialCreate
dotnet ef database update
`
"@ | Set-Content "C:\Users\walte\Documents\Trabajos del SENA\C# Rodolfo\Escritorio\ENTITY FRAMEWORK\README.md" -Encoding UTF8

# README GestorEstudiantesApp
@"
# GestorEstudiantesApp - Sistema Web de Gestion de Estudiantes

## Descripcion
Aplicacion web desarrollada con **ASP.NET Core MVC (.NET 8)** para gestionar el registro y seguimiento de estudiantes de un programa academico.

## Funcionalidades
- Listado de estudiantes con nombre, programa, promedio y estado
- Indicador visual de promedio (verde si >= 7, rojo si < 7)
- Crear nuevo estudiante con validaciones
- Editar informacion de estudiantes existentes
- Eliminar estudiantes con confirmacion

## Tecnologias
- C# .NET 8 / ASP.NET Core MVC
- Razor Views (.cshtml)
- Bootstrap 5 para el diseño
- Patron MVC (Modelo-Vista-Controlador)

## Modelos
`csharp
public class Estudiante {
    public string Nombre { get; set; }
    public string Programa { get; set; }  // Ej: ADSO
    public double Promedio { get; set; }  // 0.0 - 10.0
    public string Estado { get; set; }    // Activo, Inactivo, Graduado
}
`

## Como ejecutar
`ash
cd GestorEstudiantesApp
dotnet run
`
Navegar a: https://localhost:5001
