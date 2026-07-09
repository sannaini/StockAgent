using StockAgent.Application.Services;
using StockAgent.Infrastructure.Clients.Services;
using StockAgent.Infrastructure.Mappers;
using StockAgent.Worker.Ingestion;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddMappers(builder.Configuration);
builder.Services.AddFinnHub(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddHostedService<StockPriceIngestionWorker>();


var host = builder.Build();
host.Run();
