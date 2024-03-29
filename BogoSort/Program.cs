using BogoSort;
using BogoSort.Services;
using Cocona;
using Microsoft.Extensions.DependencyInjection;

var builder = CoconaApp.CreateBuilder();
builder.Services.AddSingleton<ISortService, BogoService>();
builder.Services.AddSingleton<IUtilStringService, UtilStringToListInt>();
var app = builder.Build();

app.AddCommands<SortCommands>();

app.Run();