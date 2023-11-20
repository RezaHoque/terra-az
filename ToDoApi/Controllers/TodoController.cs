using Microsoft.AspNetCore.Mvc;

namespace ToDoApi.Controllers;

[ApiVersion("1.0")]
[ApiController]
[Route("api/{v:apiVersion}/[controller]")]
public class TodoController : ControllerBase
{
    private readonly IConfiguration _config;
    private readonly ICosmosDbService _cosmosDbService;
    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<WeatherForecastController> logger,IConfiguration configuration)
    {
        _logger = logger;
        _config = configuration;
        _cosmosDbService =InitializeCosmos.InitializeCosmosClientInstanceAsync(_config.GetSection("CosmosDb")).GetAwaiter().GetResult();
    }

    [HttpGet(Name = "getTodo")]
    public IEnumerable<WeatherForecast> GetTodo()
    {
       
    }
}
