using System.Net.Mime;
using System.Text;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "Home", action = "Index" }
);

//app.MapGet("/", (HttpContext context) => {

//    string html = @"<html><body><h1>Hello Vanaja</h1></body></html>";
//    WriteHtml(context, html);
//});

app.Run();

//void WriteHtml(HttpContext httpContext, String html)
//{
//    httpContext.Response.ContentType = MediaTypeNames.Text.Html;
//    httpContext.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
//    httpContext.Response.WriteAsync(html);
//}