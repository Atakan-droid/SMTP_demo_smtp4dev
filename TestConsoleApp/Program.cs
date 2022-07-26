using SMTP4_Tests;

namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmtpFactory smtpFactory = new SmtpFactory();
            smtpFactory.InitializeAsync();
            System.Console.ReadLine();
            smtpFactory.DisposeAsync();
        }
    }
}
