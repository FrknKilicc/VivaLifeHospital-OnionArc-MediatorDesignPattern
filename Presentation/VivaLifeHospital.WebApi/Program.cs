using VivaLifeHospital.Application.Interfaces;
using VivaLifeHospital.Application.Interfaces.DoctorInterfaces;
using VivaLifeHospital.Application.Services;
using VivaLifeHospital.Persistance.Context;
using VivaLifeHospital.Persistance.Repositories;
using VivaLifeHospital.Persistance.Repositories.DoctorRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<VivaLifeHospitalContext>();


//Configure Irepos
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IDoctorRepository), typeof(DoctorRepository));
builder.Services.SaveAppServices(builder.Configuration);

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
