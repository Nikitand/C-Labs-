using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laba13
{
     class ONEFileInfo
    {
        const string  path = @"D:\универ\3 сем\ООп\Лабы\№13\Laba13\Laba13\onelogfile.txt";
        private static FileInfo file;
        static ONEFileInfo()
        {
            file = new FileInfo(path);
        }

        public static void Fileinf()
        {
            Console.WriteLine("Время создание: " +file.CreationTime);
        }
        public static void Info()
        {
            Console.WriteLine("Названия файла: " + file.Name);
            Console.WriteLine("Расширение файла: " + file.Extension);
            Console.WriteLine("Размер: " + file.Length);
        }
        public static void FullName()
        {
            Console.WriteLine("Полный путь: " + file.FullName);
        }
    }
  
               
   
     
}
