using System.Security.Cryptography;
using System.Text; // Added for Encoding.UTF8
using System.Net.Mime; // Added for MediaTypeNames
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", (HttpContext context) => {

//    WriteHtml(context, $@"
//                       <!doctype html>
//                       <html>
//                            <head><title> mini HTML </title></head>
//                            <body>
//                             <h1>Simple Form<h1>
//                             <br/>
//                             <form action=""/login"" method=""post"">
//                             <label for=""username"">User name:</label>
//                             <input type=""text"" id=""username"" name=""username"" required>
//                             <label for=""password"">Password:</label>
//                             <input type=""password"" id=""password"" name=""password"" required>
//                             <button type=""Submit"">  Login</button>
//                             </form>
//                             </body>
//                        </html>");
                       
      
//});
//app.MapPost("/login", (HttpContext context) =>
//{
//    var username = context.Request.Form["username"];
//    var password = context.Request.Form["password"];

//    if (username == "safali" && password == "password")
//    {
//        var html = @$" 
//                  <!doctype html> 
//                  <html>
//                       <head><title>mini HTML</title></head>
//                       <body>
//                       <h1> Simple FrameWork </h1>
//                       <br/>
//                       Welcome to simple FrameWork!
//                       </body>
//                 </html>";
//        WriteHtml(context, html);
//    }
//    else
//    {
//        var html = $@"
//                       <!doctype html>
//                       <html>
//                            <head><title> mini HTML </title></head>
//                            <body>
//                             <h1>Simple Form<h1>
//                             <br/>
//                             <form action=""/login"" method=""post"">
//                             <label for=""username"">User name:</label>
//                             <input type=""text"" id=""username"" name=""username"" required>
//                             <label for=""password"">Password:</label>
//                             <input type=""password"" id=""password"" name=""password"" required>
//                             <button type=""Submit"">  Login</button>
//                             <br/>
//                             <label style=""color:red""> Login Failed </label>
//                             </form>
//                             </body>
//                        </html>";
//        WriteHtml(context, html);
//    }
//});
                                   
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
   
    
    
    
app.Run();

//void WriteHtml(HttpContext context, string html)
//{
//    context.Response.ContentType = MediaTypeNames.Text.Html;
//    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
//    context.Response.WriteAsync(html);

//}