namespace Pastelaria.Mvc.Controllers
{
    [Route("tarefa")]
    public class TarefaController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ITarefaRepository _tarefaRepository;
        private readonly Notification _notification;

        public TarefaController(
            AppSettings appSettings,
            ITarefaRepository tarefaRepository,
            IUsuarioRepository usuarioRepository,
            Notification notification
        )
        {
            _usuarioRepository = usuarioRepository;
            _notification = notification;
        }

        public IActionResult Index() => View();

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(CadastrarTarefaViewModel cadastrarTarefaViewModel)
        {
            if (cadastrarTarefaViewModel == null)
                return BadRequest("Nenhum dado enviado.");

            if (!cadastrarTarefaViewModel.IsValid(_notification))
                return BadRequest(_notification.Get());

            var novaTarefa = new Tarefa
            {

            };

            return Ok();
        }
    }
}
