
using ServeHub.Api.CustomMiddleWares;

namespace ServeHub.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddLocalization();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }
          
            app.UseExceptionHandler("/error");
            app.UseHsts();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseRequestLocalization(
             new RequestLocalizationOptions().
              SetDefaultCulture("ar").
              AddSupportedCultures("ar", "en").
              AddSupportedUICultures("ar", "en")
           );
            app.UseCors(allow =>
            {
                allow.AllowAnyHeader();
                allow.AllowAnyMethod();
                allow.AllowAnyOrigin();
                

            });
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseDomainExceptionMiddleware();
            app.MapControllers();
       
            app.Run();
        }
    }
}
