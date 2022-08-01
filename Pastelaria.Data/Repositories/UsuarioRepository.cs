namespace Pastelaria.Data.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        
        public UsuarioRepository (ApplicationDbContext dbContext) : base(dbContext)
        {
            _applicationDbContext = dbContext;
        }
    }
}
