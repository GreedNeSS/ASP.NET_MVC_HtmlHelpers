var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
app.MapControllerRoute("UserList", "users/list/{Id?}", new { controller = "Home", action = "Users"});

app.Run();
