namespace Pastelaria.Core.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataConclusao { get; set; }
        public int IdUsuarioCadastro { get; set; }

        public StatusTarefa StatusTarefa { get; set; }
    }
}
