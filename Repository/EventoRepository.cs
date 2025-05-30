using Interface;
using Models;

namespace Repository
{
    public class EventoRepository : IEventoRepository
    {
        private readonly List<EventoBase> _eventos = new();
        private int _contadorId = 1;

        public void Adicionar(EventoBase evento)
        {
            evento.Id = _contadorId++;
            _eventos.Add(evento);
        }

        public List<EventoBase> ListarTodos() => _eventos;

        public EventoBase? BuscarPorId(int id) => _eventos.FirstOrDefault(e => e.Id == id);
    }
}