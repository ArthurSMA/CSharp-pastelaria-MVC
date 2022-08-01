namespace Pastelaria.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;

        public HomeController(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public IActionResult Index() => View();
    }
}
