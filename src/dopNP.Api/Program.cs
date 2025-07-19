using dopNP.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfig();

var app = builder.Build();

app.UseEnvironment();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
