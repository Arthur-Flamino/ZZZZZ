using APILivros.Routes;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGetRoute();

app.Run();
