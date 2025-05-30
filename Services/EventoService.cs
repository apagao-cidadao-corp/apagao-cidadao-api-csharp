using Interface;
using Models;

namespace Services
{
    public class EventoService
    {
        private readonly IEventoRepository _repo;

        public EventoService(IEventoRepository repo)
        {
            _repo = repo;
        }

        public void RegistrarFalha(string local, string descricao, string tipoFalha, DateTime data)
        {
            var evento = new EventoRegistro
            {
                Local = local,
                Descricao = descricao,
                TipoFalha = tipoFalha,
                Data = data
            };

            EventoValidacao.Validar(evento);
            _repo.Adicionar(evento);
        }

        public void GerarAlerta(string local, string descricao, int nivelCriticidade, DateTime data)
        {
            var alerta = new EventoAlerta
            {
                Local = local,
                Descricao = descricao,
                NivelCriticidade = nivelCriticidade,
                Data = data
            };

            EventoValidacao.Validar(alerta);
            _repo.Adicionar(alerta);
        }

        public List<EventoBase> ObterTodosEventos() => _repo.ListarTodos();
    }
}