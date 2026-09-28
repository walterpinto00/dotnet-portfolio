using BibliotecaApp.Models;
using Microsoft.AspNetCore.Identity;

namespace BibliotecaApp.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            // --- Sembramos Roles y Administrador ---
            string[] roles = new[] { "Administrador", "Bibliotecario", "Cliente" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            // Crear administrador por defecto
            var adminEmail = "admin@biblioteca.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                var newAdmin = new IdentityUser { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
                var result = await userManager.CreateAsync(newAdmin, "Admin123*");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(newAdmin, "Administrador");
                }
            }

            // --- Sembramos Datos de Biblioteca ---
            // Si hay menos de 10 autores, limpiamos y sembramos de nuevo
            if (context.Autores.Count() < 10)
            {
                context.Prestamos.RemoveRange(context.Prestamos);
                context.Libros.RemoveRange(context.Libros);
                context.Autores.RemoveRange(context.Autores);
                await context.SaveChangesAsync();

                // Crear 10 autores
                var autores = new List<Autor>
                {
                    new Autor { Nombre = "Gabriel García Márquez", Nacionalidad = "Colombiano", FechaNacimiento = new DateTime(1927, 3, 6) },
                    new Autor { Nombre = "Mario Vargas Llosa", Nacionalidad = "Peruano", FechaNacimiento = new DateTime(1936, 3, 28) },
                    new Autor { Nombre = "Jorge Luis Borges", Nacionalidad = "Argentino", FechaNacimiento = new DateTime(1899, 8, 24) },
                    new Autor { Nombre = "Isabel Allende", Nacionalidad = "Chilena", FechaNacimiento = new DateTime(1942, 8, 2) },
                    new Autor { Nombre = "Julio Cortázar", Nacionalidad = "Argentino", FechaNacimiento = new DateTime(1914, 8, 26) },
                    new Autor { Nombre = "Laura Esquivel", Nacionalidad = "Mexicana", FechaNacimiento = new DateTime(1950, 9, 30) },
                    new Autor { Nombre = "Carlos Fuentes", Nacionalidad = "Mexicano", FechaNacimiento = new DateTime(1928, 11, 11) },
                    new Autor { Nombre = "Octavio Paz", Nacionalidad = "Mexicano", FechaNacimiento = new DateTime(1914, 3, 31) },
                    new Autor { Nombre = "Pablo Neruda", Nacionalidad = "Chileno", FechaNacimiento = new DateTime(1904, 7, 12) },
                    new Autor { Nombre = "José Saramago", Nacionalidad = "Portugués", FechaNacimiento = new DateTime(1922, 11, 16) }
                };

                await context.Autores.AddRangeAsync(autores);
                await context.SaveChangesAsync();

                // Crear 15 libros
                var libros = new List<Libro>
                {
                    new Libro { Titulo = "Cien Años de Soledad", ISBN = "978-0307474728", AnioPublicacion = 1967, AutorId = autores[0].Id },
                    new Libro { Titulo = "El Amor en los Tiempos del Cólera", ISBN = "978-0307389732", AnioPublicacion = 1985, AutorId = autores[0].Id },
                    new Libro { Titulo = "La Ciudad y los Perros", ISBN = "978-0307475671", AnioPublicacion = 1963, AutorId = autores[1].Id },
                    new Libro { Titulo = "La Fiesta del Chivo", ISBN = "978-8420442340", AnioPublicacion = 2000, AutorId = autores[1].Id },
                    new Libro { Titulo = "Ficciones", ISBN = "978-0394177601", AnioPublicacion = 1944, AutorId = autores[2].Id },
                    new Libro { Titulo = "El Aleph", ISBN = "978-0143039243", AnioPublicacion = 1949, AutorId = autores[2].Id },
                    new Libro { Titulo = "La Casa de los Espíritus", ISBN = "978-0553273915", AnioPublicacion = 1982, AutorId = autores[3].Id },
                    new Libro { Titulo = "Paula", ISBN = "978-0060927219", AnioPublicacion = 1994, AutorId = autores[3].Id },
                    new Libro { Titulo = "Rayuela", ISBN = "978-0307474735", AnioPublicacion = 1963, AutorId = autores[4].Id },
                    new Libro { Titulo = "Como Agua para Chocolate", ISBN = "978-0385420174", AnioPublicacion = 1989, AutorId = autores[5].Id },
                    new Libro { Titulo = "La Muerte de Artemio Cruz", ISBN = "978-9681603504", AnioPublicacion = 1962, AutorId = autores[6].Id },
                    new Libro { Titulo = "El Laberinto de la Soledad", ISBN = "978-0141189451", AnioPublicacion = 1950, AutorId = autores[7].Id },
                    new Libro { Titulo = "Veinte Poemas de Amor", ISBN = "978-0140186482", AnioPublicacion = 1924, AutorId = autores[8].Id },
                    new Libro { Titulo = "Canto General", ISBN = "978-0520261314", AnioPublicacion = 1950, AutorId = autores[8].Id },
                    new Libro { Titulo = "Ensayo sobre la Ceguera", ISBN = "978-8420442357", AnioPublicacion = 1995, AutorId = autores[9].Id }
                };

                await context.Libros.AddRangeAsync(libros);
                await context.SaveChangesAsync();

                // Crear préstamos (algunos devueltos, otros pendientes)
                var prestamos = new List<Prestamo>
                {
                    new Prestamo { NombreUsuario = "Juan Pérez", FechaPrestamo = DateTime.Now.AddDays(-15), FechaDevolucion = DateTime.Now.AddDays(-2), LibroId = libros[0].Id },
                    new Prestamo { NombreUsuario = "María García", FechaPrestamo = DateTime.Now.AddDays(-5), FechaDevolucion = null, LibroId = libros[1].Id },
                    new Prestamo { NombreUsuario = "Carlos López", FechaPrestamo = DateTime.Now.AddDays(-2), FechaDevolucion = null, LibroId = libros[2].Id },
                    new Prestamo { NombreUsuario = "Ana Silva", FechaPrestamo = DateTime.Now.AddDays(-20), FechaDevolucion = DateTime.Now.AddDays(-10), LibroId = libros[3].Id },
                    new Prestamo { NombreUsuario = "Luis Torres", FechaPrestamo = DateTime.Now.AddDays(-1), FechaDevolucion = null, LibroId = libros[4].Id },
                    new Prestamo { NombreUsuario = "Pedro Gómez", FechaPrestamo = DateTime.Now.AddDays(-30), FechaDevolucion = DateTime.Now.AddDays(-15), LibroId = libros[5].Id },
                    new Prestamo { NombreUsuario = "Laura Vargas", FechaPrestamo = DateTime.Now.AddDays(-7), FechaDevolucion = null, LibroId = libros[6].Id },
                    new Prestamo { NombreUsuario = "Sofía Reyes", FechaPrestamo = DateTime.Now.AddDays(-12), FechaDevolucion = DateTime.Now.AddDays(-1), LibroId = libros[7].Id }
                };

                await context.Prestamos.AddRangeAsync(prestamos);
                await context.SaveChangesAsync();
            }
        }
    }
}
