
using CovautoAPI.Applicatie.Interfaces;
using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Applicatie.Repositories;
using CovautoAPI.Domain;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

ServiceConfiguration.RegisterServices(builder.Services, connectionString);

builder.Services.AddScoped<ILeenAutoRepository, LeenAutoRepository>();
builder.Services.AddScoped<IReserveringenRepository, ReserveringenRepository>();
builder.Services.AddScoped<IReserveringDataRepository, ReserveringDataRepository>();
builder.Services.AddScoped<ICollegaRepository, CollegaRepository>();



//builder.Services.AddScoped<BoekenRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorApp", policy =>
    {
        policy.WithOrigins("https://localhost:7265") // Blazor-app URL
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowBlazorApp");


app.UseAuthorization();

app.MapControllers();

app.Run();
