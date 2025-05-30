using Models;
namespace Interface
{
    public interface IEventoRepository
    {
        void Adicionar(EventoBase evento);
        List<EventoBase> ListarTodos();
        EventoBase? BuscarPorId(int id);
    }
}