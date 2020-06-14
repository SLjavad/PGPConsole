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
            while (true)
            {
                Console.WriteLine("Which One ?? Encrypt(E) or Decrypt(D)");
                var inputKey = Console.ReadKey();
                Console.WriteLine();
                switch (inputKey.Key)
                {
                    case ConsoleKey.E:
                        {
                            Console.WriteLine("Enter Text File Address :");
                            string textFileAddress = GetCleanPath();
                            Console.WriteLine();
                            Console.Write("Enter Public Key : ");
                            string pubFileAddr = GetCleanPath();
                            var storedFile = PGPWorker.EncryptPGP(textFileAddress, pubFileAddr);
                            Console.WriteLine();
                            Console.WriteLine($"Good! File Encrypted and stored here : {storedFile}");
                            break;
                        }
                    case ConsoleKey.D:
                        {
                            Console.WriteLine("Enter Encrypted File Address :");
                            string encryptedFileAddress = GetCleanPath();
                            Console.WriteLine();
                            Console.Write("Enter Private Key : ");
                            string privateFileAddr = GetCleanPath();
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
