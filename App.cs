using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.ConfigureKestrel(opts =>
{
    opts.ListenAnyIP(9090);
});
var app = builder.Build();
app.Map("/", () => "Hello, World");
app.Run();