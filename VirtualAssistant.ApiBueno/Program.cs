using VirtualAssistant.Infrastucture.GoogleCal;
using VirtualAssitant.Core.CategoryManager;
using VirtualAssitant.Core.Client;
using VirtualAssitant.Core.FlightManager;
using VirtualAssitant.Core.PlaceManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AviationStackClient>();
builder.Services.AddScoped<GeopifyClient>();
builder.Services.AddScoped<GoogleCalendarService>();
builder.Services.AddScoped<IFlightService, FlightService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IPlaceService, PlaceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(options => options.AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
