using Microsoft.AspNetCore.Mvc;
using ToDoApi.Models;
using ToDoApi.Services;
namespace ToDoApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
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
    
    [HttpPost]
    public TodoItem AddTodo()
    {

    }
    */
    [HttpGet(Name ="hello")]
    public string Hello(){
        return "Hello world! How are you doing";
    }
    [HttpGet(Name ="add")]
    public string add(string a, string b){
        var c=Convert.ToInt32(a)+Convert.ToInt32(b);
        return c.ToString();
    }
}
