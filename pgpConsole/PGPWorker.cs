using PgpCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace pgpConsole
{
    public class PGPWorker
    {
        private static string GetLocalPath()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            return path;
        }

        public static string EncryptPGP(string filename , string publicFileName)
        {
            string path = $@"{GetLocalPath()}\{filename}.pgp";
            using (PGP pgp = new PGP())
            {
                pgp.EncryptFile(filename, path , publicFileName, true, true);
            }
            return path;
        }
    }
}
