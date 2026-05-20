using Microsoft.EntityFrameworkCore;
using CadastroClientes.Api.Data;
using CadastroClientes.Api.Models;

namespace CadastroClientes.Api.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _context;

    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Cliente>> ListarAsync()
    {
        return await _context.Clientes.ToListAsync();
    }
}