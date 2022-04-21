using System.Net;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using real_estate_web.Data.Abstract;
using real_estate_web.Data.Common;
using real_estate_web.Data.EntityFramework;

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
builder.Services.AddScoped<IAboutRepository,EfAboutDal>();
builder.Services.AddScoped<IContactRepository,EfContactDal>();

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




var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    DataGenerator.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

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

app.UseStatusCodePages(async context => {
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
