
using CovautoAPI.Applicatie.Interfafes;
using CovautoAPI.Applicatie.Repositories;
using CovautoAPI.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

ServiceConfiguration.RegisterServices(builder.Services, connectionString);

builder.Services.AddScoped<ILeenAutoRepository, LeenAutoRepository>();

//builder.Services.AddScoped<BoekenRepository>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
