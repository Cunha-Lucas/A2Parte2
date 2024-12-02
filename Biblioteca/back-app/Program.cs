using back_app.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Cadastrar o Livro
app.MapPost("/api/livros/cadastrar", ([FromBody] Livro livro, [FromServices] AppDataContext ctx) => {
    ctx.Livros.Add(livro);
    ctx.SaveChanges();
    return Results.Created($"/livros/{livro.Id}", livro);dotnet tool install --global dotnet-ef

});

// Listar os livros cadastrados
app.MapGet("/api/livros/listar", ([FromServices] AppDataContext ctx) =>
{
    return Results.Ok(ctx.Livros.ToList());
});

// Cadastrar Usuário
app.MapPost("/api/usuarios/cadastrar", ([FromBody] Usuario usuario, [FromServices] AppDataContext ctx) => {
    ctx.Usuarios.Add(usuario);
    ctx.SaveChanges();
    return Results.Created($"/usuarios/{usuario.Id}", usuario);
});