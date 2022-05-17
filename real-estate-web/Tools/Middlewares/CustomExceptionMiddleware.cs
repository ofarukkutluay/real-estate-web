using real_estate_web.Data.Abstract;
using real_estate_web.Models.Database;
using real_estate_web.Models.HelperEntities;
using System.Diagnostics;
using System.Net;
using System.Xml;

namespace real_estate_web.Tools.Middlewares
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomExceptionMiddleware(RequestDelegate requestDelegate)
        {
            _next = requestDelegate;
        }

        public async Task Invoke(HttpContext context, ILogRepository logRepository)
        {
            var watch = Stopwatch.StartNew();
            try
            {
                string message = $"[Request]  HTTP {context.Request.Method} - {context.Request.Path}";
                Console.WriteLine(message);

                await _next(context);
                watch.Stop();

                message = $"[Response] HTTP {context.Request.Method} - {context.Request.Path} responded {context.Response.StatusCode} in {watch.Elapsed.TotalMilliseconds} ms";
                Console.WriteLine(message);

            }
            catch (Exception ex)
            {
                watch.Stop();
                await HandleException(context, ex, watch, logRepository);
            }

        }

        private async Task HandleException(HttpContext context, Exception ex, Stopwatch watch, ILogRepository logRepository)
        {
            await Task.Run(() =>
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                string message = $"HTTP {context.Request.Method} - {context.Response.StatusCode} Error Message:  {ex.Message} inner ex message: {ex.InnerException} time: {watch.Elapsed.TotalMilliseconds} ms";
                Console.WriteLine(message);
            });
            //await logRepository.AddAsync(new Log() { LogType = LogType.Error,Message=message});
            //return await logRepository.SaveAsync();
        }
    }

    public static class CustomExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}
