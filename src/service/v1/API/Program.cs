using BLL;
using IBLL;
using IDAL;
using DAL;
using Microsoft.EntityFrameworkCore;
using SysModel;
using Autofac;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region ЗўЮёзЂВс
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));
builder.Services.AddScoped<IBLLUser, BLLUserMySql>();
builder.Services.AddScoped<IDALUser, DALUserMySql>();

var autoBuilder = new ContainerBuilder();
//autoBuilder.Register<>
#endregion

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
