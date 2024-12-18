using System.Security.Cryptography;
using System.Text; // Added for Encoding.UTF8
using System.Net.Mime; // Added for MediaTypeNames
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => {

    WriteHtml(context, $@"
                       <!doctype html>
                       <html>
                            <head><title> mini HTML </title></head>
                            <body>
                             <h1>Simple Form<h1>
                             <br/>
                             <form action=""/login"" method=""post"">
                             <label for=""username"">User name:</label>
                             <input type=""text"" id=""username"" name=""username"" required>
                             <label for=""password"">Password:</label>
                             <input type=""password"" id=""password"" name=""password"" required>
                             <button type=""Submit"">  Login</button>
                             </form>
                             </body>
                        </html>");
                       
      
});
                                   

app.Run();
void WriteHtml(HttpContext context, string html)
{
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    context.Response.WriteAsync(html);

}