using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



// 1. Register the native .NET OpenAPI generator
builder.Services.AddOpenApi();

var app = builder.Build();


// 2. Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    // Map the OpenAPI JSON endpoint (creates /openapi/v1.json)
    app.MapOpenApi();

    app.MapScalarApiReference();
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
