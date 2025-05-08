using APILivros.Models;

namespace APILivros.Routes;

public static class Routes
{
    public static void MapGetRoute(this WebApplication app)
    {

        List<Livros> livros = new List<Livros>
        {
            new Livros{Id = 1, Titulo = "Abogus", Autor = "SUS", AnoPubli = 2020},
            new Livros{Id = 2, Titulo = "Steet", Autor = "Fight", AnoPubli = 2000},
            new Livros{Id = 3, Titulo = "Sapo", Autor = "Sapissimo", AnoPubli = 1490}
        };


        app.MapGet("/", () => "API estas a funegar!!");
        app.MapGet("/api/livros", () => livros);
        app.MapGet("/api/livros/{id}", (int id) => 
        {

            var livro = livros.FirstOrDefault(l => l.Id ==id);
            return livro != null ? Results.Ok(livro) : Results.NotFound("N existe"); 
        });
    }
}