using Microsoft.EntityFrameworkCore;
using ApiTareas.Data;
using ApiTareas.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.MapGet("/test", () => "API funcionando");

app.MapGet("/api/tareas", async (AppDbContext db) =>
    await db.Tareas.ToListAsync());

app.MapPost("/api/tareas", async (AppDbContext db, Tarea tarea) =>
{
    db.Tareas.Add(tarea);
    await db.SaveChangesAsync();
    return Results.Ok(tarea);
});

app.Run();