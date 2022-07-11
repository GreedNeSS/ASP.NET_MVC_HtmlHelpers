var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

app.MapControllerRoute("default", "api/{action=Index}/{Id?}", new { controller = "Home" });

app.Run();
