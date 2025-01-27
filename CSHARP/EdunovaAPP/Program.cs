using EdunovaAPP.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();


//didavanje konteksta baze podataka -> dependency injection
builder.Services.AddDbContext<EdunovaContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EdunovaContext"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.


app.MapOpenApi();


app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI(o=> {
    o.EnableTryItOutByDefault();
    o.ConfigObject.AdditionalItems.Add("requestSnippetsEnabled", true);
});


app.MapControllers();

app.Run();
