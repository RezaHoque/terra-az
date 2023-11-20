using Microsoft.AspNetCore.Mvc;
using ToDoApi.Models;
using ToDoApi.Services;
namespace ToDoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly IConfiguration _config;
  
    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger,IConfiguration configuration)
    {
        _logger = logger;
        _config = configuration;
       
    }
/*
    [HttpGet(Name = "getTodo")]
    public IEnumerable<TodoItem> GetTodo()
    {
       
    }
    */
}
