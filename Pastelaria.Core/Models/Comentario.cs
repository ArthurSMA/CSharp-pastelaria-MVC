namespace Pastelaria.Core.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public Tarefa Tarefa { get; set; }
        public Comentario ComentarioRespondido { get; set; }
    }
}