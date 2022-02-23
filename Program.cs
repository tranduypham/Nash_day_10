using Day_10.Models;
using Day_10.Repository;
using Day_10.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<StudentDbContext>(
    options=> options.UseSqlServer("Server=DESKTOP-C00IDIB;Initial Catalog=DBName;Integrated Security=True")
);
builder.Services.AddTransient<IStudent, StudentServices>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();
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
