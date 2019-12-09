using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laba13
{
    public  class ONEDiskInfo
    {
         static DriveInfo[]  disk;

       public static void DiskInfo()
        {
            disk = DriveInfo.GetDrives();
        }
      public  static void Getfreeplace()
        {
            foreach (var x in disk)
            { 
                Console.WriteLine( "Свободное место на диске " + x.TotalFreeSpace);
            }            
        }
       public static void FaileSystem()
        {           
            foreach (var x in disk)
            {
                
                Console.WriteLine("Файловая система " + x.DriveFormat);
            }            
        }
        public static void Info()
        {
            foreach (var x in disk)
            {
                Console.WriteLine("Имя :" +  x.Name);
                Console.WriteLine("Общее место :" + x.TotalSize.ToString());
                Console.WriteLine("Общее свободное место :" + x.TotalFreeSpace.ToString());
                Console.WriteLine("Метка " + x.VolumeLabel);
            }
        }
    }
}
