using Microsoft.EntityFrameworkCore;
using CadastroClientes.Api.Data;
using CadastroClientes.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// conexão com banco
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// injeção de dependência
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

// controllers
builder.Services.AddControllers();

// swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// habilitar swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();