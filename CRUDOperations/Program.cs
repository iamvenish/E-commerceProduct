using CRUDOperations.Data;
using CRUDOperations.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<TokenService>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp", policy =>
    {
        policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
    });
});
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(
         builder.Configuration.GetConnectionString("defaultConnection")
        );
});
builder.Services.AddControllers();
var app = builder.Build();
app.UseCors("AllowAngularApp");
app.MapControllers();

app.Run();
