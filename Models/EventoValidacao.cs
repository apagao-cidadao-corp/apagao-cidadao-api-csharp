namespace Models
{
    public static class EventoValidacao
    {
        public static void Validar(EventoBase evento)
        {
            if (string.IsNullOrWhiteSpace(evento.Local))
                throw new ArgumentException("Local não pode ser vazio.");

            if (evento.Data > DateTime.Now)
                throw new ArgumentException("Data não pode ser no futuro.");

            if (string.IsNullOrWhiteSpace(evento.Descricao))
                throw new ArgumentException("Descrição não pode ser vazia.");
        }
    }
}