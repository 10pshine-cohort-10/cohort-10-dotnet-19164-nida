using WebApplication1.DTOS.TaskDTOS;
using WebApplication1.Models;
using WebApplication1.Models.Enums;
using WebApplication1.EndPoints;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddValidation();

var _connectionString = "Data Source=TaskStore.db";
builder.Services.AddDbContext<TaskStoreContext>(options =>
    options.UseSqlServer(_connectionString));


var app = builder.Build();

app.MapTaskEndpoints();

app.Run();

