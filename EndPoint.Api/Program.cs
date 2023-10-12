using CarwashProject.Application.Interfaces;
using CarwashProject.Application.Services.Workers.Queries.GetWorker;
using CarwashProject.Infrastructure.Contexts;
using CarwashProject.Services.Workers.GetWorkerById;
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
builder.Services.AddScoped<IGetWorkerService, GetWorkerService>();
builder.Services.AddScoped<IGetWorkerByIdService, GetWorkerByIdService>();

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