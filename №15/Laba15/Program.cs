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
            
            int num = 0;
            // устанавливаем метод обратного вызова
            TimerCallback tm = new TimerCallback(Privet);
            // создаем таймер
            Timer timer = new Timer(tm, num, 0, 3000);


            Thread first_thread = new Thread(new ThreadStart(Task));
            first_thread.Name = "number_1";
            first_thread.Priority = ThreadPriority.Highest;
            first_thread.Start();

            first_thread.Suspend();
            var currt = Thread.CurrentThread;
            Console.WriteLine("info_about_thread");
            Console.WriteLine("-" + currt.Name + "--");
            Console.WriteLine("Priority " + currt.Priority);
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

            Console.WriteLine();
            Thread.Sleep(5000); 

            Console.WriteLine("Even_Odd");
            StartInfo t1 = new StartInfo(50, 50, true, true);
            StartInfo t2 = new StartInfo(50, 100, false, true);
         
            Thread second_thread = new Thread(new ParameterizedThreadStart(StaticClassMutex.WriteNumbers));
            Thread third_thread = new Thread(new ParameterizedThreadStart(StaticClassMutex.WriteNumbers));
            third_thread.Start(t2);
            second_thread.Start(t1);
            second_thread.Name = "number_2";
            second_thread.Priority = ThreadPriority.AboveNormal;
            third_thread.Name = "number_3";
            third_thread.Priority = ThreadPriority.Normal;
            Console.WriteLine(); ;
            Thread.Sleep(10000);
            third_thread = new Thread(new ParameterizedThreadStart(StaticClassBarrier.WriteNumbers));
            second_thread = new Thread(new ParameterizedThreadStart(StaticClassBarrier.WriteNumbers));
            third_thread.Start(t2);
            second_thread.Start(t1);
            Thread.Sleep(10000);
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

            //   my_domain.Load(new AssemblyName("System.Data"));
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
                Thread.Sleep(50);
                a++;
                Console.Write(a + " ");
                using (StreamWriter fs = new StreamWriter("Count.txt", true, System.Text.Encoding.Default))
                {
                    fs.Write(a + " ");
                    fs.Close();
                }

            }

        }
        //static void Task_2()
        //{

        //    int count = 10;
        //    int even = 0;

        //    while (even != count)
        //    {

        //        Thread.Sleep(100);
        //        Console.Write(even);

        //        using (StreamWriter fs = new StreamWriter("Even_Odd.txt", true, System.Text.Encoding.Default))
        //        {
        //            fs.Write(even);
        //            fs.Close();
        //        }
        //        even = even + 2;
        //    }
        //}
        //static void Task_3()
        //{
        //    int count = 10;
        //    int odd = 1;

        //    while (odd != count)
        //    {

        //        Thread.Sleep(150);
        //        Console.Write(odd);
        //        using (StreamWriter fs = new StreamWriter("Even_Odd.txt", true, System.Text.Encoding.Default))
        //        {
        //            fs.Write(odd);
        //            fs.Close();
        //        }
        //        odd = odd + 2;
        //    }
        //}


        static void Privet(object num)
        {
            Console.WriteLine("Повтор");
        }
    }
}
