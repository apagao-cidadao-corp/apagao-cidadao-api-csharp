using Services;
using Utils;

namespace Utils
{
    public class Menu
    {
        private readonly EventoService _servico;

        public Menu(EventoService servico)
        {
            _servico = servico;
        }

        public void Exibir()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Apagão Cidadão ===");
                Console.WriteLine("1. Registrar Falha de Energia");
                Console.WriteLine("2. Gerar Alerta Crítico");
                Console.WriteLine("3. Listar Eventos");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha: ");
                string? opcao = Console.ReadLine();

                try
                {
                    switch (opcao)
                    {
                        case "1": RegistrarFalha(); break;
                        case "2": GerarAlerta(); break;
                        case "3": Listar(); break;
                        case "0": return;
                        default: Console.WriteLine("Opção inválida."); break;
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogErro(ex.Message);
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void RegistrarFalha()
        {
            Console.Write("Local: "); string? local = Console.ReadLine();
            Console.Write("Descrição: "); string? desc = Console.ReadLine();
            Console.Write("Tipo de falha: "); string? tipo = Console.ReadLine();
            Console.Write("Data (yyyy-mm-dd): "); DateTime data = DateTime.Parse(Console.ReadLine()!);
            _servico.RegistrarFalha(local!, desc!, tipo!, data);
            Logger.Log("Falha registrada com sucesso.");
        }

        private void GerarAlerta()
        {
            Console.Write("Local: "); string? local = Console.ReadLine();
            Console.Write("Descrição: "); string? desc = Console.ReadLine();
            Console.Write("Criticidade (1-5): "); int crit = int.Parse(Console.ReadLine()!);
            Console.Write("Data (yyyy-mm-dd): "); DateTime data = DateTime.Parse(Console.ReadLine()!);
            _servico.GerarAlerta(local!, desc!, crit, data);
            Logger.Log("Alerta gerado com sucesso.");
        }

        private void Listar()
        {
            var eventos = _servico.ObterTodosEventos();
            foreach (var e in eventos)
            {
                Console.WriteLine($"#{e.Id} | {e.Data} | {e.Local} | {e.Descricao}");
            }
        }
    }
}