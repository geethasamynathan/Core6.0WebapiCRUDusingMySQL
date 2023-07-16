using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using secondAPi.Models;
using secondAPi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString=builder.Configuration.GetConnectionString("defaultconnection");

builder.Services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString,
MySqlServerVersion.LatestSupportedServerVersion));
      builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();
        builder.Services.AddTransient<IAccountRepository, AccountRepository>();
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
