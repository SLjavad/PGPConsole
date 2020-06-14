using System;

namespace pgpConsole
{
    class Program
    {

        private static string GetCleanPath()
        {
            string certAddr = Console.ReadLine();
            if (certAddr[0] == '"' && certAddr[^1] == '"')
            {
                certAddr = certAddr[1..^1];
            }
            return certAddr;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to PGP Console App");
            Console.WriteLine("Enter Text File Address :");
            string textFileAddress = GetCleanPath();
            Console.WriteLine();
            Console.WriteLine("Enter Public Key");
            
        }
    }
}
