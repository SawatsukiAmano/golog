using BLL;
using IBLL;
using IDAL;
using DAL;
using Microsoft.EntityFrameworkCore;
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


#region ·þÎñ×¢²á
//AutoMapper
builder.Services.AddAutoMapper(typeof(MyProfile));
builder.Services.AddControllers().AddNewtonsoftJson();
// IBLL¡ª¡ªBLL IDAL¡ª¡ªDAL Ó³Éä
builder.Services.AddScoped<IDALUser, DALUserMySql>();
builder.Services.AddScoped<IDALBlog, DALBlogMySql>();
builder.Services.AddScoped<IDALLabel, DALLabelMysql>();
builder.Services.AddScoped<IDALComment, DALCommentMySql>();

builder.Services.AddScoped<IBLLUser, BLLUserMySql>();
builder.Services.AddScoped<IBLLBlog, BLLBlogMySql>();
builder.Services.AddScoped<IBLLLabel, BLLLabelMySql>();
builder.Services.AddScoped<IBLLComment, BLLCommentMySql>();



//builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));
//autofac
//var autoBuilder = new ContainerBuilder();
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
app.UseHttpLogging();
app.Run();
