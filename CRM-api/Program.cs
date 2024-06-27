using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CRM_api.Data;
using Microsoft.OpenApi.Writers;
using CRM_api.Controllers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CRMContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CRMContext") ?? throw new InvalidOperationException("Connection string 'CRMContext' not found."));
}
);

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

app.Run();
