using ILikeCardGames.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ILikeCardGamesDbContext>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
