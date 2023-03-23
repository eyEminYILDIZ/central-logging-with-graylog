using Microsoft.AspNetCore.Mvc;

namespace dotnet_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	[HttpGet(Name = "Get")]
	public string Get()
	{
		_logger.LogDebug("WebAPI - Debug Message");
		_logger.LogInformation("WebAPI - Info Message");
		_logger.LogWarning("WebAPI - Warning Message");
		_logger.LogError("WebAPI - Error Message");

		return "Web API is running...";
	}
}
