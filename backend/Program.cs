using WebApplication1.DTOS;
using WebApplication1.Models;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddValidation();
//builder.Services.AddTaskStoreContext("Data Source = TaskStoreContext");

var app = builder.Build();

//migrations and endpoints
app.Run();

