using static System.Net.Mime.MediaTypeNames;

namespace DAY_3_PRACTICE.Middleware
{
    public class RequestLoggingMiddleware//defines custom middleware classs
    {
        private readonly RequestDelegate _next; //represents the next middleware in the pipeline
        //Current middleware → Next middleware → Next → Controller

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
            //asp.net automatically passes the next middlewate 
            //we store it in _next
            //this is how middleware chain is built
        }

        public async Task InvokeAsync(HttpContext context)//http context ccontains- request info(URL,method,headers
                                                          //and response
        {
            Console.WriteLine($"[LOG]{context.Request.Method}{context.Request.Path}-{DateTime.Now}");
            //this logs GET /api/user - time
            ///you are loffing
            ///HTTP method
            ///request path
            ///tIMESTAMP
            await _next(context);

            //PASSES THE REQUEST TO THE NEXT MIDDLEWARE
            //if we remove this line request will stop here and controller will never execute

        }
    }
}
