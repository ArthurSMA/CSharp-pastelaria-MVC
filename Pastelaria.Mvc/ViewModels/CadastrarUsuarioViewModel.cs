namespace Pastelaria.Mvc.ViewModels
{
    public class CadastrarUsuarioViewModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public bool IsValid(Notification notification)
        {
            if (string.IsNullOrEmpty(Nome))
                notification.Add("Nome não informado!");

            if (string.IsNullOrEmpty(Email))
                notification.Add("E-mail não informado!");

            if (string.IsNullOrEmpty(Senha))
                notification.Add("Senha não informada!");

            return !notification.Any();
        }
    }
}
