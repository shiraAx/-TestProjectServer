using _2_Services;
using _2_Services.Interfaces;
using _2_Services.ServiceClasses;
using Microsoft.Net.Http.Headers;

namespace VisitTrack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins, builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                });
            });


            builder.Services.AddControllers();

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IChildService, ChildService>();
            builder.Services.AddScoped<IParentService, ParentService>();
            builder.Services.AddRepoDependencies();
            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthorization();
            //  app.UseCors(policy => policy.WithHeaders(HeaderNames.CacheControl));

            app.MapControllers();

            app.Run();
        }
    }
}