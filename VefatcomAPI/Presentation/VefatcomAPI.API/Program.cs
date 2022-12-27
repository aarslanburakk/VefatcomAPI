using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using VefatcomAPI.Application.Validators.Deads;
using VefatcomAPI.Infrastructure.Filters;
using VefatcomAPI.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceServices();

builder.Services.AddControllers(options => options.Filters.Add<ValidationFilter>()).AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateDeadValidator>()).ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy=>policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod() ));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
