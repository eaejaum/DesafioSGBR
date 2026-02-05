using DesafioSGBR.Models;
using DesafioSGBR.Repositories;
using DesafioSGBR.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ClienteRepository>();

var app = builder.Build();

app.MapPost("/clientes", (Cliente cliente, ClienteRepository repoCliente) =>
{
    var erro = ClienteValidator.Validar(cliente, repoCliente);

    if (erro != null)
        return Results.BadRequest(erro);
    
    repoCliente.Add(cliente);
    return Results.Created($"/clientes", "Cliente criado com sucesso.");
});

app.MapGet("/clientes", (ClienteRepository repoCliente) =>
{
    return Results.Ok(repoCliente.GetAll());
});

app.Run();
