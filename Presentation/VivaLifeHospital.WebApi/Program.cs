using VivaLifeHospital.Application.Interfaces;
using VivaLifeHospital.Application.Interfaces.BlogInterfaces;
using VivaLifeHospital.Application.Interfaces.CommentInterfaces;
using VivaLifeHospital.Application.Interfaces.DepartmentInterfaces;
using VivaLifeHospital.Application.Interfaces.DoctorInterfaces;
using VivaLifeHospital.Application.Interfaces.MedicalProgramInterfaces;
using VivaLifeHospital.Application.Interfaces.TagCloudInterfaces;
using VivaLifeHospital.Application.Services;
using VivaLifeHospital.Persistance.Context;
using VivaLifeHospital.Persistance.Repositories;
using VivaLifeHospital.Persistance.Repositories.BlogRepositories;
using VivaLifeHospital.Persistance.Repositories.CommentRepositories;
using VivaLifeHospital.Persistance.Repositories.DepartmentRepositories;
using VivaLifeHospital.Persistance.Repositories.DoctorRepositories;
using VivaLifeHospital.Persistance.Repositories.MedicalProgramRepositories;
using VivaLifeHospital.Persistance.Repositories.TagCloudRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<VivaLifeHospitalContext>();


//Configure Irepos
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IDoctorRepository), typeof(DoctorRepository));
builder.Services.AddScoped(typeof(IMedicalProgramRepository), typeof(MedicalProgramRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(IDepartmentRepository), typeof(DepartmentRepository));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));
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
