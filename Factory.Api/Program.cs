
using Admin;
using Factory.Interface;
using Factory.API;
using User;
using Dashboard;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<factory1>();
builder.Services.AddScoped<AdminManager>()
.AddScoped<IInvoke,AdminManager>(s=>s.GetService<AdminManager>());

builder.Services.AddScoped<UserManager>()
.AddScoped<IInvoke,UserManager>(s=>s.GetService<UserManager>());

builder.Services.AddScoped<DashboardManager>()
.AddScoped<IInvoke,DashboardManager>(s=>s.GetService<DashboardManager>());
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
