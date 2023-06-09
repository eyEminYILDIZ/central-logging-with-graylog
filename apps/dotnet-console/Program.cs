﻿using System;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;

//==================================================================\\
//=================== Serilog Settings =============================\\
//==================================================================\\
IConfiguration Configuration = new ConfigurationBuilder()
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("serilog.json", optional: false, reloadOnChange: true)
	.AddEnvironmentVariables()
	.AddCommandLine(args)
	.Build();

Log.Logger = new LoggerConfiguration()
	.ReadFrom.Configuration(Configuration)
	.CreateLogger();
//==================================================================\\
//==================================================================\\

Log.Debug("Console - Debug Message");
Log.Information("Console - Info Message");
Log.Warning("Console - Warning Message");
Log.Error("Console - Error Message");