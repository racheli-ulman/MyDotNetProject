using CarsVolunteer.core.Repositories;
using CarsVolunteer.core.servies;
using CarsVolunteer.Core;
using CarsVolunteer.Data;
using CarsVolunteer.Data.Repositories;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Project.Servies;
<<<<<<< HEAD
using AutoMapper;

=======
using System.Text.Json.Serialization;
>>>>>>> 67d82159c6878cc396ff78664595cf6eae57196e

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddSingleton<Mapping>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerServies, CustomerServies>();

builder.Services.AddScoped<IVolunteerRepository, VolunteerRepository>();
builder.Services.AddScoped<IVolunteerServies, VolunteerServies>();

builder.Services.AddScoped<ITravelRepository, TravelRepository>();
builder.Services.AddScoped<ItravelServies, TravelServise>();

builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));
builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
