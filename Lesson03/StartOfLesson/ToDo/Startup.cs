using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.Use(async (HttpContext context, Func<Task> next) =>
            {

            });

            //app.UseMiddleware<LoggingMiddleware>();

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
    /*public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var request = await FormatRequest(context.Request);
            //gets the incoming request

            var OriginalBodyStream = context.Response.Body;
            //copies a pointer to the original body stream

            //now create a new memory stream...
            using (var responseBody = new MemoryStream())
            {
                context.Response.Body = responseBody;
                //and use that stream for the temporary response body

                await _next(context);
                //continue through pipeline and return to this class

                var response = await FormatResponse(context.Response);
                //formats the response from the server

                await responseBody.CopyToAsync(OriginalBodyStream);
                //copy contents of new memory stream to original
            }
        }

        private async Task<string> FormatResponse(HttpResponse response)
        {
            response.Body.Seek(0, SeekOrigin.Begin);
            //read response stream from the beginning

            string text = await new StreamReader(response.Body).ReadToEndAsync();
            //copy that into a string

            response.Body.Seek(0, SeekOrigin.Begin);
            //reset reader for the response so the client can read it

            return $"{response.StatusCode}: {text}";
            //return the string for the response
        }

        private async Task<string> FormatRequest(HttpRequest request)
        {
            var body = request.Body;

            request.EnableRewind();
            //function allows us to set reader back at beginning of stream

            var buffer = new byte[Convert.ToInt32(request.ContentLength)];
            //we need to read request stream. Create a byte w same length as original

            await request.Body.ReadAsync(buffer, 0, buffer.Length);
            //copy the request stream into the new buffer

            var bodyAsText = Encoding.UTF8.GetString(buffer);
            //convert the byte[] into a string

            request.Body = body;
            //assign read body back to request body - now allowed because of the EnableRewind();

            return $"{request.Scheme} {request.Host}{request.Path} {request.QueryString} {bodyAsText}";
        }
    }*/
}
