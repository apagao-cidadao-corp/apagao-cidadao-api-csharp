using Interface;
using Repository;
using Services;
using Utils;

class Program
{
    static void Main()
    {
        IEventoRepository repo = new EventoRepository();
        EventoService servico = new EventoService(repo);
        Menu menu = new Menu(servico);
        menu.Exibir();
    }
}