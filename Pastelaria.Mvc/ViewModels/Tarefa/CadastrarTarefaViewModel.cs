namespace Pastelaria.Mvc.ViewModels.Tarefa
{
    public class CadastrarTarefaViewModel
    {
        public string Descricao { get; set; }

        public bool IsValid(Notification notification)
        {
            if (string.IsNullOrEmpty(Descricao))
                notification.Add("Descricao não informada!");
            
            return !notification.Any();
        }
    }
}