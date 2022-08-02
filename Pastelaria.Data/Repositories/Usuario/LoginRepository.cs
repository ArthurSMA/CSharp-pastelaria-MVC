namespace Pastelaria.Data.Repositories
{
    public class LoginRepository : BaseRepository , ILoginRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public LoginRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _applicationDbContext = dbContext;
        }
    }
}