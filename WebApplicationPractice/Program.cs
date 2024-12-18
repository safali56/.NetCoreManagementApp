using System.Security.Cryptography;
using System.Text; // Added for Encoding.UTF8
using System.Net.Mime; // Added for MediaTypeNames
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => {
    string html = @"<html><body>
                <h1>Hello World!</h1>
                <br>
                 Welcome to this new World!
                  </body>
                  </html>";
});
                                   

app.Run();
void WriteHtml(HttpContext context, string html)
{
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    context.Response.WriteAsync(html);

}