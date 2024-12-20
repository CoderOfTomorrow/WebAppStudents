using Microsoft.EntityFrameworkCore;
using WebAppForNoobs.Database;

namespace WebAppForNoobs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //Add EntityFramework
            var connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=WebAppStudents;Integrated Security=True;TrustServerCertificate=true";

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

            //1: Add-Migration MigrationOne
            //2: Update Database
            //EndAddEntityFramework

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}