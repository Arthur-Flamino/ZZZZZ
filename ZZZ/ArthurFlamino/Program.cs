var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//GET: /
app.MapGet("/", () => "Ola essa é minha API");

//GET: /sobre
app.MapGet("/sobre", () => "Sou Arthur kakakakakakk");

//GET: /localizacao
app.MapGet("/localizacao/{param1}", () => "Centro de Curitiba");


//GET: /contato
app.MapGet("/contato", () => "(41)1212-1212");

//GET: /produtos
app.MapGet("/produtos", () => "cell\nfone\ntablet");

app.Run();
