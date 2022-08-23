using DAL.MySql;
using BLL.MySql;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region 服务注册
{//读取appsettings配置
    builder.Services.AddSingleton(new Appsettings(builder.Configuration));
}

{ //AutoMapper
    builder.Services.AddAutoMapper(typeof(MyProfile));
}

{ //IBLL——BLL IDAL——DAL 映射
    builder.Services.AddScoped<IDALUser, DALUserMySql>();
    builder.Services.AddScoped<IDALBlog, DALBlogMySql>();
    builder.Services.AddScoped<IDALLabel, DALLabelMysql>();
    builder.Services.AddScoped<IDALComment, DALCommentMySql>();

    builder.Services.AddScoped<IBLLUser, BLLUserMySql>();
    builder.Services.AddScoped<IBLLBlog, BLLBlogMySql>();
    builder.Services.AddScoped<IBLLLabel, BLLLabelMySql>();
    builder.Services.AddScoped<IBLLComment, BLLCommentMySql>();
}

{ //JWT鉴权
    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
           options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters()
               {
                   ValidateIssuer = false,
                   ValidateAudience = false,
                   ValidateLifetime = true,
                   //ValidAudience = null,
                   //ValidIssuer=null,
                   ValidateIssuerSigningKey = true,
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("")),
               };
           }
           );
}

//获取请求信息
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
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

//鉴权
app.UseAuthorization();
app.UseHttpLogging();//start the http logs
app.MapControllers();



app.Run();
