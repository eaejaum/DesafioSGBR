using DesafioSGBR.Models;

namespace DesafioSGBR.Repositories;

public class ClienteRepository
{
    private readonly List<Cliente> _clientes = [];

    public IEnumerable<Cliente> GetAll() => _clientes;

    public bool EmailExiste(string email) =>
        _clientes.Any(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

    public void Add(Cliente cliente) => _clientes.Add(cliente);
}