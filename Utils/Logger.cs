namespace Utils
{
    public static class Logger
    {
        public static void Log(string mensagem)
        {
            Console.WriteLine($"[LOG {DateTime.Now}] {mensagem}");
        }

        public static void LogErro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERRO {DateTime.Now}] {mensagem}");
            Console.ResetColor();
        }
    }
}