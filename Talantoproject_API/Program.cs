using Microsoft.EntityFrameworkCore;
using TalantoProject.Common.Repositories;
using TalantoProject.Common.Services;
using TalantoProject.Dao.DB;
using TalantoProject.Dao.Repositores;
using TalantoProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAccountServices, AccountService>();
builder.Services.AddTransient<IAccountRepositories, AccountRepository>();

builder.Services.AddDbContext<Talantoproject_DbContext>(options=>
     options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"])
);

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
