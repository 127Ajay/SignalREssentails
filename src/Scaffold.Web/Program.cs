var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(configure =>
{
    configure.MapHub<ViewHub>("/hubs/view");
});

app.UseDefaultFiles(); //index.html 
app.UseStaticFiles();
app.Run();
