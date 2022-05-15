using BLL;
using IBLL;
using IDAL;
using DAL;
using Microsoft.EntityFrameworkCore;
using SysModel;
using Autofac;
using System.Net;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Model;
using ModelRes;
using CommonHelper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MyProfile));

#region ЗўЮёзЂВс
builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));
builder.Services.AddScoped<IBLLUser, BLLUserMySql>();
builder.Services.AddScoped<IDALUser, DALUserMySql>();
builder.Services.AddScoped<IBLLBlog, BLLBlogMySql>();
builder.Services.AddScoped<IDALBlog, DALBlogMySql>();
//autofac
//var autoBuilder = new ContainerBuilder();
//autoBuilder.Register<>
#endregion


var configuration = new AutoMapper.MapperConfiguration(cfg =>
{
    cfg.CreateMap<blog, Blog>();
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
app.UseHttpLogging();
app.Run();
