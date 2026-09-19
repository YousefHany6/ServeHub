using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using ServeHub.Api.Resources;
using ServeHub.Domain.Exceptions;
using System.Threading.Tasks;

namespace ServeHub.Api.CustomMiddleWares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class DomainExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public DomainExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext,IStringLocalizer<SharedResources> localizer)
        {

            try
            {
                await _next(httpContext);
            }
            catch (DomainException ex)
            {
                var message = localizer[
               ex.ErrorCode,
               ex.Args ?? Array.Empty<string>()].Value;

                httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
                httpContext.Response.ContentType = "application/json; charset=utf-8";
               

                await httpContext.Response.WriteAsJsonAsync(new
                {  
                    message = message           
                });

            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class DomainExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseDomainExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DomainExceptionMiddleware>();
        }
    }
}
