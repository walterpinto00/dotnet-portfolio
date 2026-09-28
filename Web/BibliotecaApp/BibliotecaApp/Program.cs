using Microsoft.EntityFrameworkCore;
using BibliotecaApp.Data;
using BibliotecaApp.Services;
using Microsoft.AspNetCore.Identity;

namespace BibliotecaApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => {
                options.SignIn.RequireConfirmedAccount = false;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/AccessDenied";
            });

            // ✅ Registrar el servicio de Autor
            builder.Services.AddScoped<IAutorService, AutorService>();
            
            // ✅ Registrar el servicio de Libro
            builder.Services.AddScoped<ILibroService, LibroService>();
            
            // ✅ Registrar el servicio de Prestamo
            builder.Services.AddScoped<IPrestamoService, PrestamoService>();

            // ✅ Registrar el servicio de Dashboard
            builder.Services.AddScoped<IDashboardService, DashboardService>();

            // ✅ Registrar el servicio de Usuarios
            builder.Services.AddScoped<IUsuarioService, UsuarioService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();


            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                    
                    // Aplicar migraciones automáticamente en el servidor
                    await context.Database.MigrateAsync();
                    
                    await DbSeeder.SeedAsync(context, userManager, roleManager);
                    Console.WriteLine("Datos seed insertados correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar datos seed: " + ex.Message);
                }
            }

            await app.RunAsync();
        }
    }
}