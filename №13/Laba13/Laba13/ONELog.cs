using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laba13
{
    class ONELog
    {
        private string path;
        private StreamWriter writer;
        private FileSystemWatcher watcher;

        public ONELog(string _path)
        {
            path = _path;
            writer = new StreamWriter(path);
            watcher = new FileSystemWatcher(@"D:\");

            watcher.Changed += new FileSystemEventHandler(OnChange);
            watcher.EnableRaisingEvents = true;
        }

        private void OnChange(object source, FileSystemEventArgs e)
        {
            writer.WriteLine($"[{DateTime.Now}] {e.FullPath} {e.ChangeType}");
        }

        public void close()
        {
            writer.Close();
            watcher.EnableRaisingEvents = false;
        }

        public void GetByCurrentMinute(string _path)
        {
            StreamReader reader = new StreamReader(path);
            StreamWriter writer = new StreamWriter(_path);
            List<string> list = new List<string>();
            List<string> FinalList = new List<string>();

            while (!reader.EndOfStream)
            {
                list.Add(reader.ReadLine());
            }

            foreach (string x in list)
            {
                if (x.Substring(15, 2) == DateTime.Now.Minute.ToString())
                    FinalList.Add(x);
            }

            foreach (string x in FinalList)
            {
                writer.WriteLine(x);
            }

            reader.Close();
            writer.Close();
        }
    }

}

