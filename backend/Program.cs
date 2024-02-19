using backend.Extensions;
using backend.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

ConfigureServices.SetupServices(builder.Services);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGroup("/auth").MapIdentityApi<User>();

app.UseHttpsRedirection();
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("*"));

app.MapControllers();
app.Run();
