using Library_Management_Api.DALs;
using Library_Management_Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<BookService>();

builder.Services.AddScoped<ConsultaLivro>();
builder.Services.AddScoped<CriarLivro>();
builder.Services.AddScoped<AtualizarLivro>();
builder.Services.AddScoped<DeletarLivro>();
builder.Services.AddScoped<ConsultaLivroId>();
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
