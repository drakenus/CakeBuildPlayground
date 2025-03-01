using SimpleLib;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var app = builder.Build();

app.MapGet("/hello", () =>
{
    var hello = new HelloWorld();
    return hello.SayHello();
});

app.Run();