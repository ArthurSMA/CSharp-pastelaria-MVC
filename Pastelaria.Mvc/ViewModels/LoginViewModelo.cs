namespace Pastelaria.Mvc.ViewModels
{
    public class LoginViewModel
    {
        public String Email { get; set; };
        public String Senha { get; set; };

        public bool IsValid (Notification notification)
        {
            if (string.IsNullOrEmpty(Email))
                notification.Add("O email não foi informado!");
            
            if (string.IsNullOrEmpty(Senha))
                notification.Add("A senha não foi informada!");

            return !notification.Any();
        }
    }
}