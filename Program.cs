using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scaffold.WebApi.Data;
using Scaffold.WebApi;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ScaffoldWebApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ScaffoldWebApiContext") ?? throw new InvalidOperationException("Connection string 'ScaffoldWebApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapCustomerEndpoints();

app.Run();
