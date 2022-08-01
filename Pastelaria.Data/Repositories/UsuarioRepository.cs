namespace Pastelaria.Data.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UsuarioRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _applicationDbContext = dbContext;
        }

        public async Task<Usuario> BuscarPorEmailAsync(string email)
        {
            return await _applicationDbContext.Usuarios
                .AsSingleQuery()
                .Where(x => x.Email.Equals(email))
                .Select(x => new Usuario
                {
                    Id = x.Id,
                    Email = x.Email,
                    Senha = x.Senha
                })
                .FirstOrDefaultAsync();
        }

        public async Task CadastrarAsync(Usuario usuario)
        {
            await _applicationDbContext.Usuarios.AddAsync(usuario);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
