//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();
//===============================================================

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseDefaultFiles();

app.UseStaticFiles();

app.Run();