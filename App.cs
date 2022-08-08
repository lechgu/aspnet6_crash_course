using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(opts =>
{
    opts.ListenAnyIP(9090);
});
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();