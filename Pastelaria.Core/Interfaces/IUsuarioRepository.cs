namespace Pastelaria.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> BuscarPorEmailAsync(string email);
        Task CadastrarAsync(Usuario usuario);
        Task<IDbTransaction> BeginTransactionAsync();
        IDbTransaction BeginTransaction();
    }
}
