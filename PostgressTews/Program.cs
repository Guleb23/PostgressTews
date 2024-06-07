using Microsoft.EntityFrameworkCore;

namespace PostgressTews
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddDbContext<Context>(options =>
            {
                options.UseNpgsql("Host=82.97.248.8;Port=5432;Database=default_db;Username=gen_user;Password=:z)gb?12c.UWyi");
            });
            var app = builder.Build();
            app.UseHttpsRedirection();
            app.MapGet("/", (Context context) =>
            {
                return context.Users.FirstOrDefault(); 
            });

            app.Run();
        }
    }
}
