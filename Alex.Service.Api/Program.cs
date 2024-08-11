using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Alex.Service.Db;
using System;
using Microsoft.Extensions.Configuration; // Убедитесь, что это правильное пространство имен для вашего DbContext

var builder = WebApplication.CreateBuilder(args);

// Получение строки подключения из конфигурации
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Добавление DbContext в контейнер зависимостей
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

// Добавление других служб
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Добавление Swagger (если нужно)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Конфигурация промежуточного ПО (middleware)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
