namespace Labb1_MVC.Middlewares
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"I ErrorMiddleware: {context.Request.Path}");
            await _next(context);

            Console.WriteLine($"I ErrorMiiddleware: {context.Response.StatusCode}");

            if (context.Response.StatusCode == 404)
            {
                context.Items["Message"] = "Detta är inte sidan du letar efter";
                context.Request.Path = "/Home/Error";

                await _next(context);
            }
        }
    }
}
