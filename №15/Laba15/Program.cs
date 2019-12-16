using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Loader;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Laba15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Procecs();
           Domain();

            Thread first_thread = new Thread(new ThreadStart(Task));
            first_thread.Name = "number_1";
            first_thread.Priority = ThreadPriority.Highest;
            first_thread.Start();

              first_thread.Suspend();

            var currt = Thread.CurrentThread;
            Console.WriteLine("info_about_thread");
            Console.WriteLine("-" + currt.Name+ "--");
            Console.WriteLine("Priority "+currt.Priority);
            Console.WriteLine(" Sostoinie " + currt.ThreadState);
            Console.WriteLine("Id " + currt.ManagedThreadId);
            if (currt.IsAlive)
            {
                Console.WriteLine("Working");
            }
            if (!currt.IsBackground)
            {
                Console.WriteLine("not Background");
            }
           first_thread.Resume();
            
            Console.WriteLine(  );
            Thread second_thread = new Thread(new ThreadStart(Task_2));
            Thread third_thread = new Thread(new ThreadStart(Task_3));
            second_thread.Name = "number_2";
            second_thread.Priority = ThreadPriority.AboveNormal;
            third_thread.Name = "number_3";
            third_thread.Priority = ThreadPriority.Normal;
            Console.WriteLine("Even_Odd");
            second_thread.Start();
            third_thread.Start();
            
        }

        static void Procecs()
        {
            foreach (Process process in Process.GetProcesses())
            {
                using (StreamWriter sw = new StreamWriter("Info.txt", true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("ID " + process.Id + "Mashine_name " + process.MachineName + "Name " + process.ProcessName + " Priority " + process.BasePriority);
                    sw.Close();
                    Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}  Priority:  {process.BasePriority} Mashine_NAme {process.MachineName} ");
                }
            }
        }

        static void Domain()
        {
            Console.WriteLine();
            Console.WriteLine("Info_Domain");
            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine($" name: { domain.FriendlyName}");
            Console.WriteLine($"configuration: {domain.ShadowCopyFiles}");
            Console.WriteLine("Sborki");
            Assembly[] assemblies_1 = domain.GetAssemblies();
            foreach (Assembly asm in assemblies_1)
                Console.WriteLine(asm.GetName().Name);
            Console.WriteLine();
            Console.WriteLine("create domain");
            AppDomain my_domain = AppDomain.CreateDomain("My_Domain");

           my_domain.Load(new AssemblyName("System.Data"));
            Assembly[] assemblies_2 = my_domain.GetAssemblies();
            foreach (var x in assemblies_1)
            {
                Console.WriteLine("name " + x.GetName().Name);
                Thread.Sleep(20);

            }
            AppDomain.Unload(my_domain);
        }
        static void Task()
        {
             
                int n = 50;
                int a = 0;
                while (a != n)
                {
                    Thread.Sleep(100);
                    a++;
                    Console.Write(a + " ");
                    using (StreamWriter fs = new StreamWriter("Count.txt", true, System.Text.Encoding.Default))
                    {
                        fs.Write(a + " ");
                        fs.Close();
                    }

                }
            
        }
            static void Task_2()
            {

            int count = 50;
            int even = 0;
           
            while (even != count)
            {
                
                Thread.Sleep(100);
                Console.WriteLine(even);

                using (StreamWriter fs = new StreamWriter("Even_Odd.txt", true, System.Text.Encoding.Default))
                {
                    fs.Write(even);
                    fs.Close();
                }
                even = even + 2;
            }
            }
        static void Task_3()
        {
            int count = 51;
            int odd = 1;
           
            while (odd != count)
            {
                
                Thread.Sleep(150);
                Console.WriteLine(odd);
                using (StreamWriter fs = new StreamWriter("Even_Odd.txt", true, System.Text.Encoding.Default))
                {
                    fs.Write(odd);
                    fs.Close();
                }
                odd = odd + 2;
            }
        }
        
    }
}
