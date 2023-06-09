using Microsoft.EntityFrameworkCore;
using PortfolioApi.Infrastucture;
using PortfolioApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<PostContext>(opt =>
    opt.UseInMemoryDatabase("PostList"));
builder.Services.AddDbContext<RecallContext>(opt =>
    opt.UseInMemoryDatabase("RecallList"));
builder.Services.AddDbContext<WorksContext>(opt =>
    opt.UseInMemoryDatabase("WorksList"));
builder.Services.AddDbContext<AboutMeContext>(opt =>
    opt.UseInMemoryDatabase("AboutMeList"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
