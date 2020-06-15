using PgpCore;
using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                string name = new FileInfo(filename).Name;
                name = name.Substring(0, name.LastIndexOf('.'));

                string path = $@"{GetLocalPath()}\{name}.pgp";
                using (PGP pgp = new PGP())
                {
                    pgp.EncryptFile(filename, path, publicFileName, true, true);
                }
                return path;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "ERROR";
            }
            
        }

        public static string DecryptPGP(string filename, string privateFileName , string passphrase)
        {
            try
            {
                string name = new FileInfo(filename).Name;
                name = name.Substring(0, name.LastIndexOf('.'));

                string path = $@"{GetLocalPath()}\{name}.txt";
                using (PGP pgp = new PGP())
                {
                    pgp.DecryptFile(filename, path, privateFileName, passphrase);
                }
                return path;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "ERROR";
            }
            
        }
    }
}
