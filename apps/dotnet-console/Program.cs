using System;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;

IConfiguration Configuration = new ConfigurationBuilder()
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("serilog.json", optional: false, reloadOnChange: true)
	.AddEnvironmentVariables()
	.AddCommandLine(args)
	.Build();

Log.Logger = new LoggerConfiguration()
	.ReadFrom.Configuration(Configuration)
	.CreateLogger();

Log.Debug("Debug Message");
Log.Information("Info Message");
Log.Warning("Warning Message");
Log.Error("Error Message");