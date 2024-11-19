using System.Globalization;
using ClassLibrary1HomeTaskScheduler.Identity;
using HomeTaskScheduler.API.Constants;
using HomeTaskScheduler.API.Middleware;
using HomeTaskScheduler.Application;
using HomeTaskScheduler.Application.Utils.Convertors;
using HomeTaskScheduler.Infrastructure;
using HomeTaskScheduler.Persistence;
using Microsoft.OpenApi.Models;
using Serilog;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<RouteHandlerOptions>(options => { options.ThrowOnBadRequest = true; });

using var log = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration)
    .MinimumLevel.Information()
    .CreateLogger();
Log.Logger = log;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});

builder.Services.AddCors(x =>
{
    x.AddPolicy("UI", cors =>
    {
        cors.WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

// builder.Services.AddHttpsRedirection(x =>
// {
//     x.HttpsPort = 7295;
// });

builder.Services.ConfigureApplicationServices(builder.Configuration);
builder.Services.ConfigurePersistenceServices(builder.Configuration);
builder.Services.ConfigureIdentityServices(builder.Configuration);
builder.Services.ConfigureInfrastructureServices(builder.Configuration);
builder.Services.AddControllers(x => { x.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true; })
    .AddJsonOptions(opt => { opt.JsonSerializerOptions.PropertyNamingPolicy = null; })
    .AddNewtonsoftJson(o =>
    {
        o.UseMemberCasing();
        o.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;
        o.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;

        var datetimeConverter = new Newtonsoft.Json.Converters.IsoDateTimeConverter()
        {
            Culture = CultureInfo.GetCultureInfo("en"),
            DateTimeFormat = AppConstants.DateTimeFullFormat
        };
        o.SerializerSettings.Converters.Add(datetimeConverter);

        o.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
        o.SerializerSettings.Converters.Add(new DateOnlyJsonConverter());
    });
builder.Services.AddMemoryCache();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("UI");
app.UseExceptionMiddleware();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.MapGet("/lol", async context => await context.Response.WriteAsync("LOLOLO"));

app.Run();