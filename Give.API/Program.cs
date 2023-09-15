using Give.DataAccess.Abstractions;
using Give.DataAccess.Repositories;
using Give.Service.Abstractions;
using Give.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySQL(builder.Configuration.GetConnectionString("db")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
// Configure API versioning
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
});

// Configure Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1.0", new OpenApiInfo { Title = "API", Version = "v1.0" });

    // Add API versioning support to Swagger
    c.DocInclusionPredicate((version, desc) =>
    {
        if (!desc.TryGetMethodInfo(out var methodInfo)) return false;
        var versions = methodInfo.DeclaringType?
            .GetCustomAttributes(true)
            .OfType<ApiVersionAttribute>()
            .SelectMany(attr => attr.Versions);

        var maps = methodInfo.GetCustomAttributes(true)
            .OfType<MapToApiVersionAttribute>()
            .SelectMany(attr => attr.Versions)
            .ToArray();

        return versions?.Any(v => $"v{v}" == version) == true || maps.Any(v => $"v{v}" == version);
    });
});

builder.Services.AddScoped<ICampaignService, CampaignService>();
builder.Services.AddScoped<ICampaignRepository, CampaignRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "API v1.0");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
