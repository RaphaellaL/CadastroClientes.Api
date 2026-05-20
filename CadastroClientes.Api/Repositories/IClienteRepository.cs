using CadastroClientes.Api.Models;

namespace CadastroClientes.Api.Repositories;

public interface IClienteRepository
{
    Task<List<Cliente>> ListarAsync();
}