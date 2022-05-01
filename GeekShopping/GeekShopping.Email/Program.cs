using GeekShopping.Email.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Context Database
var connection = builder.Configuration["MySqlConnection:MySqlConnectionString"];

builder.Services.AddDbContext<MySqlContext>(options =>
    options.EnableSensitiveDataLogging(true)
           .UseMySql(connection, new MySqlServerVersion(new Version(10, 6))));

var builderDb = new DbContextOptionsBuilder<MySqlContext>();
builderDb.UseMySql(connection, new MySqlServerVersion(new Version(10, 6)));

var app = builder.Build();

app.UseHttpsRedirection();