﻿using PgpCore;
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
            string name = new FileInfo(filename).Name;
            name = name.Substring(0, name.LastIndexOf('.'));

            string path = $@"{GetLocalPath()}\{name}.pgp";
            using (PGP pgp = new PGP())
            {
                pgp.EncryptFile(filename, path , publicFileName, true, true);
            }
            return path;
        }
    }
}
