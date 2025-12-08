using BooksStore.DataAccess;
using BooksStore.DataAccess.Repositories;
using BookStore.Application.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BookStoreDBContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(BookStoreDBContext)));
});



builder.Services.AddScoped<IBooksService, BooksService>();
builder.Services.AddScoped<IBooksRepositories, BookSRepositories>();


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



