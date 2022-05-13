var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddFilter("Microsoft.AspNetCore.SignalR", LogLevel.Trace);
builder.Logging.AddFilter("Microsoft.AspNetCore.Http.Connections", LogLevel.Trace);


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
