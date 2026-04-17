using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
//Creates the application builder
//Prepares configuration, services, environment
//starting point of the app

// Add services to the container.

builder.Services.AddControllers();//registers controllers into the app 
//without this controllers wont work at all
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//adds openApi/Swagerr services 
//this is used to generate the documentation of the api
var app = builder.Build();
//builds the application from configuration or final app
//this is the actual running application

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}
//enables open api endpoint 
//this is only enabled in development mode

app.UseHttpsRedirection();
//redirects http to https

app.UseAuthorization();
//enables authorization

app.MapControllers();
//connects incoming requests to the correct controller

app.Run();
//starts the application
