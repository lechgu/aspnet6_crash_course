﻿using dotenv.net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

DotEnv.Load();
var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
config.AddEnvironmentVariables();
if (!int.TryParse(config["PORT"], out int port))
{
    port = 9090;
}
builder.WebHost.ConfigureKestrel(opts =>
{
    opts.ListenAnyIP(port);
});
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();