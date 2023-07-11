namespace Pastelaria.Mvc.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        private readonly ILoginRepository _loginRepository;
        private readonly IUsuarioRepository usuarioRepository;
        private readonly Notification _notification;

        public LoginController (
            AppSettings _appSettings;
            ILoginRepository loginRepository;
            IUsuarioRepository usuarioRepository;
            Notification notification;
        )
        {
            _loginRepository = loginRepository;
            _usuarioRepository = usuarioRepository;
            _notification = notification; 
        }

        public async Task<IActionResult> LoginController (LoginViewModel loginViewModel) 
        {
            if (loginViewModel == null)
                return BadRequest("Nenhum dado foi enviado!");
            
            if (!loginViewModel.IsValid(_notification))
                return BadRequest(_notification.Get());

            var usuario = await _usuarioRepository.BuscarPorEmailAsync(
                loginViewModel.Email && loginViewModel.Senha);
            if (usuario.Email == null || usuario.Email != loginViewModel.Email 
                && usuario.Senha == null || usuario.Senha != loginViewModel.Senha)
                return BadRequest("E-mail ou senha inválido!");

            return Ok();
        }
    }
}
