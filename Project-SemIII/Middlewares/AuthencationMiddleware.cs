namespace Project_SemIII.Middlewares
{
 
    public class AuthencationMiddleware
    {

        private readonly RequestDelegate _next;


        public AuthencationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.StartsWithSegments("/admin") && !context.Request.Path.Equals("/admin/login"))
            {
                // Check if the user is authenticated
                if (context.Session.GetInt32("logged") == null)
                {
                    context.Response.Redirect("/admin/login");
                    return;
                }
            }
            await _next(context);
        }

    }
}
