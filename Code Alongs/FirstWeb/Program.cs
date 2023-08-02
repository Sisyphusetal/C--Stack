var builder = WebApplication.CreateBuilder(args);
//Add our service
//Line below allows us to use Controllers and Views folders
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Our builder code
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");


//app.MapGet("/", () => "Hello World!");


//This line will always be last, no code should be added beneath this
app.Run();
