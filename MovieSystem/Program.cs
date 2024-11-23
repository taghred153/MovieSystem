using Microsoft.EntityFrameworkCore;
using MovieSystem;
using MovieSystem.Repository.CategoryRepository;
using MovieSystem.Repository.DirectorRepository;
using MovieSystem.Repository.MovieRepository;
using MovieSystem.Repository.NationalityRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connection = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));
builder.Services.AddScoped<IMovieRepo, MovieRepo>();
builder.Services.AddScoped<IDirectorRepo, DirectorRepo>();
builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
builder.Services.AddScoped<INationalityRepo, NationalityRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//taghred
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
