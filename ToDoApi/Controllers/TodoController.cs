using Microsoft.AspNetCore.Mvc;
using ToDoApi.Data;
using ToDoApi.Models;
using ToDoApi.Services;
namespace ToDoApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class TodoController : ControllerBase
{
    private readonly IConfiguration _config;
  
    private readonly ILogger<TodoController> _logger;
    private readonly ApplicationDbContext _context;

    public TodoController(ILogger<TodoController> logger,IConfiguration configuration,ApplicationDbContext context)
    {
        _logger = logger;
        _config = configuration;
        _context = context;
       
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
    public string add(TodoItem item){
    if (item == null)
    {
        return "Item is null";
    }

    var todoDbItem = new TodoItem();
    todoDbItem.id = Guid.NewGuid().ToString();
    todoDbItem.title = item.title;
    todoDbItem.description = item.description;
    todoDbItem.isComplete = false;
    todoDbItem.dueDate = item.dueDate;
    todoDbItem.priority = item.priority;
    todoDbItem.category = item.category;

    _context.ToDoItems.Add(todoDbItem);
    _context.SaveChanges();
    return "Item added successfully";

        
         





    }
}
