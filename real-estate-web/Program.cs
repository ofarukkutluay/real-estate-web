using System.Net;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NpgsqlTypes;
using real_estate_web.Data.Abstract;
using real_estate_web.Data.Common;
using real_estate_web.Data.EntityFramework;
using real_estate_web.Tools.Logger;
using real_estate_web.Tools.Middlewares;
using real_estate_web.Tools.Scrapping;
using Serilog;
using Serilog.Context;
using Serilog.Core;
using Serilog.Sinks.PostgreSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<RealEstateDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresSQL")));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

builder.Services.AddScoped<IAgentRepository, EfAgentDal>();
builder.Services.AddScoped<IDeedStatusRepository, EfDeedStatusDal>();
builder.Services.AddScoped<IDistrictRepository, EfDistrictDal>();
builder.Services.AddScoped<IFrontRepository, EfFrontDal>();
builder.Services.AddScoped<IHeatingTypeRepository, EfHeatingTypeDal>();
builder.Services.AddScoped<IInternetTypeRepository, EfInternetTypeDal>();
builder.Services.AddScoped<IJobTitleRepository, EfJobTitleDal>();
builder.Services.AddScoped<INeighborhoodRepository, EfNeighborhoodDal>();
builder.Services.AddScoped<IPropertyPhotoRepository, EfPropertyPhotoDal>();
builder.Services.AddScoped<IPropertyRepository, EfPropertyDal>();
builder.Services.AddScoped<IPropertyTypeRepository, EfPropertyTypeDal>();
builder.Services.AddScoped<ICityRepository, EfCityRepository>();
builder.Services.AddScoped<IStatusRepository, EfStatusDal>();
builder.Services.AddScoped<IStreetRepository, EfStreetDal>();
builder.Services.AddScoped<IUsingStatusRepository, EfUsingStatusDal>();
builder.Services.AddScoped<IAboutRepository, EfAboutDal>();
builder.Services.AddScoped<IContactRepository, EfContactDal>();
builder.Services.AddScoped<IBlogRepository, EfBlogDal>();
builder.Services.AddScoped<ScrappingService>();

Logger log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(Path.Combine("logs","log.txt"))
    .WriteTo.PostgreSQL(builder.Configuration.GetConnectionString("PostgresSQL"),"serilogs",needAutoCreateTable:true,
    columnOptions: new Dictionary<string, ColumnWriterBase>
        {
            {"message", new RenderedMessageColumnWriter(NpgsqlDbType.Text)},
            {"message_template", new MessageTemplateColumnWriter(NpgsqlDbType.Text)},
            {"level", new LevelColumnWriter(true , NpgsqlDbType.Varchar)},
            {"time_stamp", new TimestampColumnWriter(NpgsqlDbType.Timestamp)},
            {"exception", new ExceptionColumnWriter(NpgsqlDbType.Text)},
            {"log_event", new LogEventSerializedColumnWriter(NpgsqlDbType.Json)},
            {"user_id", new UserIdColumnWriter()},
            {"remote_ip",new RemoteIpColumnWriter()},
        })
    .Enrich.FromLogContext()
    .MinimumLevel.Information()
    .CreateLogger();

builder.Host.UseSerilog(log);




builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.RequestHeaders.Add("sec-ch-ua-mobile");
    logging.RequestHeaders.Add("sec-ch-ua-platform");
    logging.RequestHeaders.Add("sec-fetch-site");
    logging.RequestHeaders.Add("sec-fetch-mode");
    logging.RequestHeaders.Add("sec-fetch-user");
    logging.RequestHeaders.Add("sec-fetch-dest");
    logging.RequestHeaders.Add("Cookie");
    logging.RequestHeaders.Add("Upgrade-Insecure-Requests");
    logging.RequestHeaders.Add(":method");
    logging.RequestHeaders.Add("Referer");
    logging.RequestHeaders.Add("Origin");
    logging.RequestHeaders.Add("Cache-Control");
    logging.RequestHeaders.Add("Pragma");
    logging.RequestHeaders.Add("Set-Cookie");
    logging.RequestHeaders.Add("X-Frame-Options");
    logging.RequestHeaders.Add("ETag");

    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Token:Issuer"],
        ValidAudience = builder.Configuration["Token:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddCors();

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
//dateonly veri tipindeki datayý kaydederken -infinity veri olarak kaydetmesini önlemek için eklendi.
AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);


//using (var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//    DataGenerator.Initialize(services);
//}

//app.UseCustomExceptionMiddleware();
app.UseCors(policy => policy.AllowAnyHeader()
                            .AllowAnyMethod()
                            .SetIsOriginAllowed(origin => true)
                            .AllowCredentials());

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSerilogRequestLogging();

app.UseHttpLogging();

app.UseSession();
app.Use(async (context, next) =>
{
    var token = context.Session.GetString("Token");
    if (!string.IsNullOrEmpty(token))
    {
        context.Request.Headers.Add("Authorization", "Bearer " + token);
    }
    await next();
});

app.UseStatusCodePages(async context =>
{
    var request = context.HttpContext.Request;
    var response = context.HttpContext.Response;

    if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
    {
        response.Redirect("/Auth/Login");
    }
    else if (response.StatusCode == (int)HttpStatusCode.Forbidden)
    {
        response.Redirect("/Home/Forbidden");
    }
});


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Use(async (context, next) =>
{
    var userid = context.User?.Identity?.IsAuthenticated == true ? context.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier)?.Value : null;
    LogContext.PushProperty("user_id", userid);
    var remoteIp = context.Connection.RemoteIpAddress?.ToString();
    LogContext.PushProperty("remote_ip", remoteIp);
    await next();
});

app.Run();
