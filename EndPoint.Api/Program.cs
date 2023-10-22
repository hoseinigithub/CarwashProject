using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.Cars.Commands.Create;
using CarwashProject.Application.Services.Cars.Commands.Delete;
using CarwashProject.Application.Services.Cars.Commands.Update;
using CarwashProject.Application.Services.Cars.Queries.GetCar;
using CarwashProject.Application.Services.Cars.Queries.GetCarById;
using CarwashProject.Application.Services.Khadamats.Commands.Create;
using CarwashProject.Application.Services.Khadamats.Commands.Delete;
using CarwashProject.Application.Services.Khadamats.Commands.Update;
using CarwashProject.Application.Services.Khadamats.Queries.GetKhadamat;
using CarwashProject.Application.Services.Khadamats.Queries.GetKhadamatById;
using CarwashProject.Application.Services.Workers.Commands.GetWorker;
using CarwashProject.Application.Services.Workers.Commands.GetWorkerById;
using CarwashProject.Application.Services.Workers.Queries.CreateWorker;
using CarwashProject.Application.Services.Workers.Queries.Delete;
using CarwashProject.Application.Services.Workers.Queries.Update;
using CarwashProject.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(option => option.AddPolicy("policyCors", build =>
{
    build.AllowAnyHeader();
    build.AllowAnyMethod();
    build.AllowAnyOrigin();
}));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("sql")));
builder.Services.AddScoped<IAppDbContext, AppDbContext>();
//Worker
builder.Services.AddScoped<IGetWorkerService, GetWorkerService>();
builder.Services.AddScoped<IGetWorkerByIdService, GetWorkerByIdService>();
builder.Services.AddScoped<ICreateWorkerService, CreateWorkerService>();
builder.Services.AddScoped<IDeleteWorkerService, DeleteWorkerService>();
builder.Services.AddScoped<IUpdateWorkerService, UpdateWorkerService>();
// Khadamat
builder.Services.AddScoped<IGetKhadamatService, GetKhadamatService>();
builder.Services.AddScoped<IGetKhadamatByIdService, GetKhadamatByIdService>();
builder.Services.AddScoped<ICreateKhadamatService, CreateKhadamatService>();
builder.Services.AddScoped<IDeleteKhadamatService, DeleteKhadamatService>();
builder.Services.AddScoped<IUpdateKhadamatService, UpdateKhadamatService>();
//Car
builder.Services.AddScoped<IGetCarService, GetCarService>();
builder.Services.AddScoped<IGetCarByIdService, GetCarByIdService>();
builder.Services.AddScoped<ICreateCarService, CreateCarService>();
builder.Services.AddScoped<IDeleteCarService, DeleteCarService>();
builder.Services.AddScoped<IUpdateCarService, UpdateCarService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("policyCors");
app.UseAuthorization();

app.MapControllers();

app.Run();