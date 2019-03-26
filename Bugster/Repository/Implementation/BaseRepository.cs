using System;

namespace Bugster.Repository
{
    public abstract class BaseRepository
    {
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"[Info-{this.GetType().FullName}]-{message}");
            Console.ResetColor();
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[Error-{this.GetType().FullName}]-{message}");
            Console.ResetColor();
        }
        public void LogError(string message, Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[Error-{this.GetType().FullName}]-{message}- Exception:{ex}");
            Console.ResetColor();
        }
    }
}
