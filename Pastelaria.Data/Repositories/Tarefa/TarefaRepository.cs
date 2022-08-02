namespace Pastelaria.Data.Repositories
{
    public class TarefaRepository : BaseRepository//, ITarefaRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public TarefaRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _applicationDbContext = dbContext;
        }

        public async Task<Tarefa> BuscarPorId(int Id)
        {
            return await _applicationDbContext.Tarefas
                .AsSingleQuery()
                .Where(x => x.Id.Equals(Id))
                .Select(x => new Tarefa
                {
                    Id = x.Id,
                    Descricao = x.Descricao,
                    DataInicio = x.DataInicio
                })
                .FirstOrDefaultAsync();
        }
    }
}
