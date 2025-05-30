namespace Models
{
    public abstract class EventoBase
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}