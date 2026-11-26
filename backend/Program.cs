using System.Reflection.Metadata.Ecma335;
using WebApplication1.DTOS.TaskDTOS;
using WebApplication1.Models;
using WebApplication1.Models.Enums;

const string endpointName = "GetTask";

var builder = WebApplication.CreateBuilder(args);

// Temporary in-memory storage - test data
List<TaskDTO> tasks =
[
    new TaskDTO
    {
        Id = 1,
        TaskName = "Learn ASP.NET Core",
        UserName = "Nida",
        Category = "Learning",
        DueDate = new DateOnly(2026, 12, 1),
        Priority = TaskPriority.High,
        IsCompleted = false
    },

    new TaskDTO
    {
        Id = 2,
        TaskName = "Complete internship assignment",
        UserName = "Nida",
        Category = "Work",
        DueDate = new DateOnly(2026, 12, 5),
        Priority = TaskPriority.Medium,
        IsCompleted = false
    },

    new TaskDTO
    {
        Id = 3,
        TaskName = "Practice CRUD operations",
        UserName = "Ali",
        Category = "Development",
        DueDate = new DateOnly(2026, 11, 28),
        Priority = TaskPriority.Low,
        IsCompleted = true
    }
];
var app = builder.Build();

// GET: Retrieve all tasks
app.MapGet("/tasks", () =>
{
    return Results.Ok(tasks);
});


// GET: Retrieve a task by ID
app.MapGet("/tasks/{id}", (int id) =>
{
    var task = tasks.Find(task => task.Id == id);
    if (task == null)
        return Results.NotFound();
    return Results.Ok(task);
}).WithName(endpointName);

// POST: Create a task
app.MapPost("/tasks", (CreateTaskDTO newTask) =>
{
    TaskDTO task = new()
    {
        Id = tasks.Count + 1,
        TaskName = newTask.TaskName,
        UserName = newTask.UserName,
        Category = newTask.Category,
        DueDate = newTask.DueDate,
        Priority = newTask.Priority ?? TaskPriority.Medium,
        IsCompleted = newTask.IsCompleted
    };
    tasks.Add(task);
    return Results.CreatedAtRoute(endpointName, new { id = task.Id },task);
});

//PUT

app.MapPut("/tasks/{id}", (int id, UpdateTaskDTO updateTask) =>
{
    var index = tasks.FindIndex(task => task.Id == id);
    if (index == -1)
        return Results.NotFound();

    tasks[index] = new TaskDTO
    {
        Id = id,
        TaskName = updateTask.TaskName,
        UserName = updateTask.UserName,
        Category = tasks[index].Category,
        DueDate = updateTask.DueDate,
        Priority = updateTask.Priority,
        IsCompleted = updateTask.IsCompleted ?? tasks[index].IsCompleted
    };

    return Results.NoContent();
});

//DELETE

app.MapDelete("/tasks/{id}", (int id) =>
{
    var task = tasks.Find(task => task.Id == id);
    if (task == null)
        return Results.NotFound();
    else{
        tasks.RemoveAll(task => task.Id == id);

        return Results.Ok(task);
    }
});

app.Run();

 //put post and delet follow along with the video