using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laba13
{
    class ONEDirinfo
    {
        const string path = @"D:\универ\3 сем\ООп\Лабы\№13\Laba13\Laba13";
        private static DirectoryInfo dir;
        static ONEDirinfo()
        {
            dir = new DirectoryInfo(path);
        }
        public static void Getname()
        {
           
            Console.WriteLine("Имя каталога: " + dir.Name);
           
        }
        public static void Getfullname()
        {

            Console.WriteLine("Полное имя " + dir.FullName);

        }
        public static void Getcount()
        {
            int count = 0;
            
            string[] files = Directory.GetFiles(path);
            foreach (string s in files)
            {
                
                count++;
            }
            Console.WriteLine($"Кол-во файлов {count}");
        }
        public static void info()
        {
            Console.WriteLine($"Время создания каталога: {dir.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dir.Root}");
        }
    }
}
