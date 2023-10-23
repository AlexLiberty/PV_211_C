using NLog;

Logger logger = LogManager.GetCurrentClassLogger();
logger.Info("Firs comment");
logger.Error("Error");

static void Test(string message)
{
    for (int i = 0; i < 50; i++)
    {
        Console.WriteLine(message + ": " + i);
    }

}
 static async void Async1()
{
    await Task.Run(() => Test("Async1"));
}
 static async void Async2()
{
    await Task.Run(() => Test("Async2"));
}
static void Main(string[] args)
{
    Async1();
    Async2();
    Console.WriteLine("Start");
    Console.ReadLine();
}
