# AplicacionRolesInventario - Control de Acceso por Roles

## Descripcion
Aplicacion web en **ASP.NET Core MVC** que implementa un sistema de control de acceso basado en **roles de usuario** (Admin y Usuario normal) para la gestion de un inventario de productos tecnologicos.

## Funcionalidades por Rol
| Funcionalidad | Admin | Usuario |
|---|---|---|
| Ver inventario completo | Si | Si |
| Agregar producto | Si | No |
| Eliminar producto | Si | No |
| Ver precios y stock | Si | Si |

## Credenciales de Prueba
| Usuario | Contrasena | Rol |
|---------|-----------|-----|
| admin | admin123 | Administrador |
| usuario | user123 | Usuario |

## Tecnologias
- C# .NET 8 / ASP.NET Core MVC
- Sessions (HttpContext.Session) para manejo de autenticacion
- Bootstrap 5 para diseño responsive
- Patron MVC con control de acceso manual por rol

## Como ejecutar
`ash
cd AplicacionRolesInventario
dotnet run
`
Navegar a: https://localhost:5001 y usar las credenciales de prueba.
