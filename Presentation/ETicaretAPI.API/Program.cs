using ETicaretAPI.Persistence;
using ETicaretAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistenceService();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.WithOrigins("https://localhost:44353/").AllowAnyHeader().AllowAnyMethod()));


builder.Services.AddControllers();


builder.Services.AddDbContext<ETicaretAPIDbContext>(options =>
options.UseNpgsql(
builder.Configuration.GetConnectionString("ConnectionStrings")!)
);



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
