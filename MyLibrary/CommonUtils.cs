using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace MyLibrary
{

    public class CommonUtils
    {
        /// <summary>
        /// Hashing a string to hash code
        /// </summary>
        /// <param name="value">Input string</param>
        public static void HashingMD5(ref string value)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.Default.GetBytes(value));
            value = "";
            for (int i = 0; i < hash.Length; i++)
            {
                value += hash[i].ToString("X2");
            }

        }

        /// <summary>
        /// Write something to notepad
        /// </summary>
        /// <param name="content">Document content</param>
        public static void OpenNotepad(string content = "This is the content of document")
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory + "\\output.txt";
            System.IO.File.WriteAllText(dir, content);
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("notepad", dir);
            process.Start();
        }

    }

}
