// namespace Pastelaria.Mvc.Controllers
// {
//     [Route("login")]
//     public class LoginController : Controller
//     {
//         private readonly ILoginRepository _loginRepository;
//         private readonly IUsuarioRepository _usuarioRepository;
//         private readonly Notification _notification;
//         public LoginController(
//             AppSettings appSettings,
//             ILoginRepository loginRepository,
//             IUsuarioRepository usuarioRepository,
//             Notification notification
//         )
//         {
//             _loginRepository = loginRepository;
//             _usuarioRepository = usuarioRepository;
//             _notification = notification;
//         }

//         [HttpGet]
//         public IActionResult Index()
//         {
//             var session = HttpContext.Session.Get<Usuario>("Usuario");
            
//             if (session != null)
//                 return RedirectToAction("Index", "Home");

//             return View();
//         }

//         [HttpPost]
//         public async Task<IActionResult> Login(LoginViewModel loginViewModel)
//         {            
//             if (HttpContext.Session.Get("Usuario") != null)
//                 return View("Index", "Home");

//             if (loginViewModel == null)
//                 return BadRequest("Nenhum dado foi informado");

//             var usuario = await _usuarioRepository.BuscarPorEmailAsync(loginViewModel.Email);
            
//             if (usuario == null || loginViewModel.Senha.Criptografar() != usuario.Senha)
//                 return BadRequest("Email ou senha incorretos!");

//             HttpContext.Session.Set<Usuario>("Usuario", usuario);

//             return View("Index", "Home");
//         } 

//         [HttpGet("Logout")]
//         public IActionResult Logout()
//         {
//             HttpContext.Session.Clear();
//             return RedirectToAction("Index");
//         }
//     }
// }
