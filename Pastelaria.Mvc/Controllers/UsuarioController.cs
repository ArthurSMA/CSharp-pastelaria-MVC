namespace Pastelaria.Mvc.Controllers
{
    [Route("usuario")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly Notification _notification;

        public UsuarioController(AppSettings appSettings,
        IUsuarioRepository usuarioRepository,
        Notification notification
        )
        {
            _usuarioRepository = usuarioRepository;
            _notification = notification;
        }

        public IActionResult Index() => View();

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(CadastrarUsuarioViewModel cadastrarUsuarioViewModel)
        {
            if (cadastrarUsuarioViewModel == null)
                return BadRequest("Nenhum dado enviado.");

            if (!cadastrarUsuarioViewModel.IsValid(_notification))
                return BadRequest(_notification.Get());

            var usuario = await _usuarioRepository.BuscarPorEmailAsync(cadastrarUsuarioViewModel.Email);
            if (usuario != null)
                return BadRequest("Usuário já existe.");

            var novoUsuario = new Usuario
            {
                Nome = cadastrarUsuarioViewModel.Nome,
                Email = cadastrarUsuarioViewModel.Email,
                Senha = cadastrarUsuarioViewModel.Senha.Criptografar()
            };
            
            return Ok();
        }
    }
}
