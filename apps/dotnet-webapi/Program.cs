using Serilog;

var builder = WebApplication.CreateBuilder(args);

//==================================================================\\
//=================== Serilog Settings =============================\\
//==================================================================\\
IConfiguration Configuration = new ConfigurationBuilder()
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("serilog.json", optional: false, reloadOnChange: true)
	.AddEnvironmentVariables()
	.AddCommandLine(args)
	.Build();

var logger = new LoggerConfiguration()
	.ReadFrom.Configuration(Configuration)
	.CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);
//==================================================================\\
//==================================================================\\

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
