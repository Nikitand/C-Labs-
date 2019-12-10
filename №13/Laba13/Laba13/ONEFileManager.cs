using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Laba13
{
    class ONEFileManager
    {

        static public string path = @"D:\универ\3 сем\ООп\";

        private static DirectoryInfo dir;
        static ONEFileManager()
        {
            dir = new DirectoryInfo(path);
        }
        public static void Get()
        {           
            Console.WriteLine("Подкаталоги:");
            string[] dirs = Directory.GetDirectories(path);
            foreach (string s in dirs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("Файлы:");
            string[] files = Directory.GetFiles(path);
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            string path_1 = @"D:\универ\3 сем\ООп\ONEInspect\";
            if (!dir.Exists)
            {
                return;
            }
            Directory.CreateDirectory(path_1);
            string path_2 = @"D:\универ\3 сем\ООп\ONEInspect\onedirinfo.txt";
            using (StreamWriter writer = new StreamWriter(path_2))
            {
                writer.WriteLine("Каталоги: ");
                foreach (var x in dirs)
                    writer.WriteLine(x);
                writer.WriteLine("Файлы: ");
                foreach (var x in files)
                    writer.WriteLine(x);
            }
            string  path_3 = @"D:\универ\3 сем\ООп\ONEInspect\newName.txt";
            File.Copy(path_2, path_3, true);
            File.Delete(path_2);
        }
        public static void Get_2()
        {
            //string path = @"D:\универ\3 сем\ООп\";
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles().Where(s => s.Extension == ".txt").ToArray();
            string Path = path;
            path += @"ONEFile\";
            Directory.CreateDirectory(path);
            foreach (var f in files)
            {
                if (File.Exists(path))
                    File.Delete(path);
                File.Move(f.FullName, path + f.Name);
            }
            Path += @"ONEInspect\ONEFile\";
            if (Directory.Exists(Path))
                Directory.Delete(Path, true);
            Directory.Move(path, Path);
        }
        public static void GetToZip()
        {
            string startpath = @"D:\универ\3 сем\ООп\ONEInspect";
            string zippath = @"D:\универ\3 сем\ООп\ONErar\result.zip";
            string extractpath = @"D:\универ\3 сем\ООп\extract";
            ZipFile.CreateFromDirectory(startpath, zippath);
            ZipFile.ExtractToDirectory(zippath, extractpath);
        }
    }
}

