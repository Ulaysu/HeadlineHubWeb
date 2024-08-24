using HeadlineHubWeb.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NewsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:NewsAppConnection"]);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
