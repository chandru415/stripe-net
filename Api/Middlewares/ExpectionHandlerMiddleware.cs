using Application.Common.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Stripe;
using System.Threading.Tasks;

namespace Api.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExpectionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExpectionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            try
            {
                await _next(httpContext);
            }
            catch (FluentValidation.ValidationException ex)
            {
                httpContext.Response.StatusCode = 400;
                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(ex));
            }
            catch (StripeException ex)
            {
                httpContext.Response.StatusCode = 400;
                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(ex));
            }
            catch (ValidationException ex)
            {
                httpContext.Response.StatusCode = 400;
                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(ex));
            }
            catch (Exception ex)
            {
                httpContext.Response.StatusCode = 500;
                httpContext.Response.ContentType = "application/json";
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(ex));
            }
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExpectionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseExpectionHandlerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExpectionHandlerMiddleware>();
        }
    }
}
