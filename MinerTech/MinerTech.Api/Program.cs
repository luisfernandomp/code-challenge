using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MinerTech.Api.Filters;
using MinerTech.Application.Services;
using MinerTech.Domain.Entities;
using MinerTech.Domain.Interfaces;
using MinerTech.Infra.Context;
using MinerTech.Infra.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<MinerTechContext>();

builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddTransient(typeof(IBaseService<>), typeof(BaseService<>));
builder.Services.AddScoped<NotificationContext>();
builder.Services.AddScoped<NotificationFilter>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers(config =>
{
    config.Filters.Add<NotificationFilter>();
});

builder.Services.AddDbContext<MinerTechContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

builder.Services.AddTransient<IUsuarioService, UsuarioService>();
builder.Services.AddTransient<IMinerioService, MinerioService>();
builder.Services.AddTransient<IClasseService, ClasseService>();

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
