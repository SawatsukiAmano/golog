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

#region ·þÎñ×¢²á
{//¶ÁÈ¡appsettingsÅäÖÃ
    builder.Services.AddSingleton(new Appsettings(builder.Configuration));
}

{ //AutoMapper
    builder.Services.AddAutoMapper(typeof(MyProfile));
}

{ //IBLL¡ª¡ªBLL IDAL¡ª¡ªDAL Ó³Éä
    builder.Services.AddScoped<IDALUser, DALUserMySql>();
    builder.Services.AddScoped<IDALBlog, DALBlogMySql>();
    builder.Services.AddScoped<IDALLabel, DALLabelMysql>();
    builder.Services.AddScoped<IDALComment, DALCommentMySql>();

    builder.Services.AddScoped<IBLLUser, BLLUserMySql>();
    builder.Services.AddScoped<IBLLBlog, BLLBlogMySql>();
    builder.Services.AddScoped<IBLLLabel, BLLLabelMySql>();
    builder.Services.AddScoped<IBLLComment, BLLCommentMySql>();
}

{ //JWT¼øÈ¨
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
//app.MapGet();

app.UseHttpLogging();
app.Run();
