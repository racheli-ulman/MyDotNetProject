using CarsVolunteer.core.Repositories;
using CarsVolunteer.core.servies;
using CarsVolunteer.Data;
using CarsVolunteer.Data.Repositories;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Project.Servies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
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

builder.Services.AddCors(opt => opt.AddPolicy("MyPolicy", policy =>
{
    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
}));

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
