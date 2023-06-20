var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapDefaultControllerRoute();
app.UseStaticFiles();
//app.MapControllerRoute(
//    name: "default",
//    pattern:"{contoller:home}/{action:index}/{id?}"
//    );
app.Run();
