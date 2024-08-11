using System;
using System.IO;

namespace ReadMyFile
{
    class Program
    {
        public static void Main()
        {
            string filePath = @"D:\1\Новая папка\";
            if (!File.Exists(filePath))
            {
                string[] allfiles = Directory.GetFiles(filePath, "", SearchOption.TopDirectoryOnly);
                for (int i = 0; i < allfiles.Length; i++) 
                {
                    string plase = allfiles[i];
                    Console.WriteLine(plase);
                    File.Delete(plase);
                }
                Console.WriteLine("+");

            }
            else { Console.WriteLine("-"); }
        }
    }
}
