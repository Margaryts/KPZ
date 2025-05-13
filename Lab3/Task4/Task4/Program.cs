using Task4;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";
        File.WriteAllText(filePath, "Hello\nWorld!");

        ISmartTextReader reader = new SmartTextReader();
        ISmartTextReader checker = new SmartTextChecker(reader);
        checker.ReadText(filePath);

        Console.WriteLine();

        ISmartTextReader locker = new SmartTextReaderLocker(reader, ".*secret.*");

        string publicFile = "public_notes.txt";
        if (!File.Exists(publicFile))
        {
            File.WriteAllText(publicFile, "This is a public file.\nNo secrets here.");
        }

        locker.ReadText("secret_notes.txt"); 

        locker.ReadText("public_notes.txt"); 
    }

}