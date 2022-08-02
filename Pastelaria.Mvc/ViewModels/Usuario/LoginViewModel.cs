namespace Pastelaria.Mvc.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Senha { get; set; }

        public bool IsValid(Notification notification)
        {

            if (string.IsNullOrEmpty(Email))
                notification.Add("E-mail não informado!");

            if (string.IsNullOrEmpty(Senha))
                notification.Add("Senha não informada!");

            return !notification.Any();
        }
    }
}
