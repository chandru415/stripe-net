namespace Api.Middlewares
{
    public class EnableBufferingMiddleware
    {
        private readonly RequestDelegate _next;

        public EnableBufferingMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            context.Request.EnableBuffering();
            await _next(context);

            if (context.Request.Body.CanSeek)
            {
                context.Request.Body.Position = 0;
            }
        }
    }
}
