using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laba13
{
    class Program
    {
        static void Main(string[] args)
        {
            ONELog log = new ONELog(@"D:\Log.txt");
            StreamWriter str;
            string str1;
            ONEDiskInfo.DiskInfo();
            ONEDiskInfo.Info();
            ONEDiskInfo.FaileSystem();
            ONEDiskInfo.Getfreeplace();
            Console.WriteLine();
            ONEFileInfo.Info();
            ONEFileInfo.FullName();
            ONEFileInfo.Fileinf();
            Console.WriteLine();
            ONEDirinfo.Getname();
            ONEDirinfo.Getfullname();
            ONEDirinfo.info();
            ONEDirinfo.Getcount();
            Console.WriteLine();
            ONEFileManager.Get();
            ONEFileManager.Get_2();
            ONEFileManager.GetToZip();
            str1 = Console.ReadLine();
            while (str1 != "q")
            {
                str = new StreamWriter(@"D:\11.txt");
                str.WriteLine(str1);
                str1 = Console.ReadLine();
                str.Close();
            }

            log.close();
            log.GetByCurrentMinute(@"D:\FinalLog.txt");
        }







    }
}
