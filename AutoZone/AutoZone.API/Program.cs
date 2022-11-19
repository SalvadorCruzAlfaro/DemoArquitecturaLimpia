using AntoZone.LogicaUperCase;
using AutoZone.Common.Interfaces;
using AutoZone.Common.Interfaces.Logica;
using AutoZone.Common.Interfaces.Repositorio;
using AutoZone.Infraestructura.AccesoDatos.Repositorios;
using AutoZone.Infraestructura.Servicios;
using AutoZone.Negocio;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddMediatR(typeof(EmptyHandler));

builder.Services.AddSingleton<ISucursalRepositorio, SucursalFakeRepositorio>();
builder.Services.AddSingleton<ILogicaUpperCase, SucursalUperCaseService>();
builder.Services.AddSingleton<IAutoZone, AutoZoneService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
