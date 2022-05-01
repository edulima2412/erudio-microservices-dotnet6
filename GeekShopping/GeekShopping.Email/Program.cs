using GeekShopping.Email.MessageConsumer;
using GeekShopping.Email.Model.Context;
using GeekShopping.Email.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Context Database
var connection = builder.Configuration["MySqlConnection:MySqlConnectionString"];

builder.Services.AddDbContext<MySqlContext>(options =>
    options.EnableSensitiveDataLogging(true)
           .UseMySql(connection, new MySqlServerVersion(new Version(10, 6))));

var builderDb = new DbContextOptionsBuilder<MySqlContext>();
builderDb.UseMySql(connection, new MySqlServerVersion(new Version(10, 6)));

builder.Services.AddSingleton(new EmailRepository(builderDb.Options));
builder.Services.AddScoped<IEmailRepository, EmailRepository>();

builder.Services.AddHostedService<RabbitMQPaymentConsumer>();

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();