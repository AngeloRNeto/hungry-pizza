using HungryPizza.Api;
using HungryPizza.Api.Mapping;
using HungryPizza.Data;
using HungryPizza.Infrastructure;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddHungryPizzaApiDependencyInjection();
builder.Services.AddHungryPizzaServiceDependencyInjection();
builder.Services.AddHungryPizzaRepositoryDependencyInjection(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
