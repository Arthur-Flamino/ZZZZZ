using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//REQUEST/REQUISIÇÃO 
// - URL e Método HTT
// - Parâmetro opcional

//GET - pega a informação
//POST - envia a informação

//GET: /
app.MapGet("/", () => "Hello é o KRL!!!!");

//GET: /teste
app.MapGet("/teste", () => "FelaDa pulga");

//GET: /parametro/param
app.MapGet("/parametro/{param1}", ([FromRoute]string param1) => 
{
    string result = param1 + " " + DateTime.Now;
    return result; 
});

app.Run();
