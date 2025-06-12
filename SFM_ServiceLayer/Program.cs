
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SFM_DataAccessLayer;
using SFM_DataAccessLayer.Models;

namespace SFM_ServiceLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddDbContext<FacilityManagementDbContext>(options =>
            //options.UseSqlServer(builder.Configuration.GetConnectionString("SFMDBConnectionString")));

            //builder.Services.AddScoped<Repository>();


            builder.Services.AddControllers();
           builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCors(
                options => options.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
                );

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
