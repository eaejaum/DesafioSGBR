using System.Net.Mail;
using DesafioSGBR.Models;
using DesafioSGBR.Repositories;

namespace DesafioSGBR.Validators;

public static class ClienteValidator
{
    public static string? Validar(Cliente cliente, ClienteRepository repo)
    {
        if (string.IsNullOrWhiteSpace(cliente.Nome))
            return "Nome é obrigatório.";

        if (string.IsNullOrWhiteSpace(cliente.Email))
            return "Email é obrigatório.";

        if (!EmailValido(cliente.Email))
            return "Email inválido.";

        if (repo.EmailExiste(cliente.Email))
            return "Email já cadastrado.";

        return null;
    }

    private static bool EmailValido(string email)
    {
        try
        {
            var addr = new MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}