namespace Pastelaria.Core.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<IDbTransaction> BeginTransactionAsync();
        IDbTransaction BeginTransaction();
    }
}
