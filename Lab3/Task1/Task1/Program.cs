using Task1;

class Program
{
    static void Main()
    {
        Logger consoleLogger = new Logger();
        consoleLogger.Log("Успішна операція");
        consoleLogger.Warn("Попередження про обмеження");
        consoleLogger.Error("Фатальна помилка");

        FileWriter fileWriter = new FileWriter("log.txt");
        IWriter fileLogger = new FileLoggerAdapter(fileWriter);

        fileLogger.Log("Успішна операція (файл)");
        fileLogger.Warn("Попередження про обмеження (файл)");
        fileLogger.Error("Фатальна помилка (файл)");

        Console.WriteLine("\nЛогування завершено. Перевірте файл log.txt.");
    }
}








