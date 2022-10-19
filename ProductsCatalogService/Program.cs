using Microsoft.AspNet.OData.Extensions;
using ProductsCatalogService.Model.Data;

namespace ProductsCatalogService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<IProductsCatalogRepository, ProeductsCatalogEFRepository>();

            builder.Services.AddControllers().AddXmlSerializerFormatters().AddNewtonsoftJson();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddOData();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(ep =>
            {
                ep.EnableDependencyInjection();
                ep.Select().OrderBy().MaxTop(10).Filter().SkipToken().Count();
                ep.MapControllers();
            });

            //app.MapControllers();

            app.Run();
        }
    }
}