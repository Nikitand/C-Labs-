using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace lab16
{
    public static class Methods
    {

        private const long maxNum = 1000;

        //прерывание задач
        private static CancellationTokenSource source = new CancellationTokenSource();
        private static CancellationToken token = source.Token;

        public static void SimpleNumberSearch()
        {
            for (long i = 2; i <= maxNum; i++)
            {
                if (AreSimple(i)) ;

                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("прерывание");
                    return;
                }
            }
        }

        private static bool AreSimple(long num)
        {

            for (long i = 2; i <= (num / 2); i++)
                if (num % i == 0)
                    return false;
            return true;
        }


        public static void Task1()
        {
            int itaration = 3;
            Stopwatch stopwatch = new Stopwatch();
            while (itaration > 0)
            {
                stopwatch.Start();
                Task task = Task.Factory.StartNew(SimpleNumberSearch);
                Console.WriteLine($"Task{itaration} id: {task.Id.ToString()}");
                Console.WriteLine($"Task{itaration} status: {task.Status.ToString()}");
                task.Wait();
                stopwatch.Stop();
                Console.WriteLine($"Time{itaration}: {stopwatch.Elapsed.TotalMilliseconds.ToString()}\n");
                stopwatch.Reset();
                itaration--;
                Console.WriteLine("------");
            }
            Console.WriteLine();
        }

        public static void Task2()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Task task = Task.Factory.StartNew(SimpleNumberSearch);
            Console.WriteLine($"id: {task.Id.ToString()}");
            Console.WriteLine($"status: {task.Status.ToString()}");

            Console.WriteLine("Exit = 0 ");
            if (Console.ReadKey().KeyChar == '0')
                source.Cancel();

            task.Wait();
            stopwatch.Stop();
            Console.WriteLine($"Time: {stopwatch.Elapsed.TotalMilliseconds.ToString()}\n");
            Console.WriteLine();
        }

        // formula oma I=U*R
        const int I = 10;
        const int U = 50;
        const int R = 100;

        public static int GetSilaToka() => I * R;
        public static int GetNapruga() => I / R;
        public static int GetSoprotivlenie() => I / U;

        public static async void Task3_4Asinc()
        {
            Task<int> task1 = Task.Factory.StartNew(GetSilaToka);
            Task<int> task2 = Task.Factory.StartNew(GetNapruga);
            Task<int> task3 = Task.Factory.StartNew(GetSoprotivlenie);

            await task1.ContinueWith((firstTask) => Console.WriteLine($"First result: {firstTask.Result}"));
            await task2.ContinueWith((secondTask) => Console.WriteLine($"Second  result: {secondTask.Result}"));
            await task3.ContinueWith((thirdTask) => Console.WriteLine($"Third result: {thirdTask.Result}"));

            task3.ContinueWith((thirdTask) => Console.WriteLine($"Third - GetAwaiter(): {thirdTask.Result}")).GetAwaiter();
            task2.ContinueWith((secondTask) => Console.WriteLine($"Second - GetAwaiter().GetResult(): {secondTask.Result}")).GetAwaiter().GetResult();
            Console.WriteLine();
        }


        // начальный индекс элемента в цикле, а второй параметр - конечный индекс. 
        //Третий параметр - делегат Action - указывает на метод, который будет выполняться один раз за итерацию:
        public static void parallels()
        {
            const int arrSize = 1000000;
            const int arrCount = 10;
            Stopwatch stopwatch = Stopwatch.StartNew();
            Parallel.For(0, arrCount, (Count) =>
            {
                int[] arr = new int[arrSize];
                Parallel.ForEach(arr, (el) =>
                {
                    el = arrCount * arrCount;
                });
            });
            stopwatch.Stop();
            Console.WriteLine("parralel.for and parralel.foreach: " + stopwatch.Elapsed.Milliseconds.ToString());
            stopwatch.Restart();
            for (int i = 0; i < arrCount; i++)
            {
                int[] arr = new int[arrSize];
                for (int j = 0; j < arr.Length; j++)
                    arr[j] = arrCount * arrCount;
            }
            stopwatch.Stop();
            Console.WriteLine("two operators: " + stopwatch.Elapsed.Milliseconds.ToString());
            Console.WriteLine();
        }
        //Выполняется параллельно. Предназначено для выполнения на разных ядрах. принимает значение методов
        public static void Task6()
        {
            Parallel.Invoke(Task6Handler, Task6Handler, Task6Handler);
            Console.WriteLine();
        }

        private static void Task6Handler()
        {
            int[] arr = new int[100000];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i * i;
            Console.WriteLine("Parallel.Invoke");
        }

        // BlockingCollection- task
        public class Task7
        {
            private static int productCount;
            private static BlockingCollection<string> products;

            
            private static void PutProuct()
            {
                int productsToPutCount = 1;

                for (int i = 0; i < productsToPutCount; i++, productCount++)
                    products.Add("product" + productCount);
                Console.WriteLine($"Producer put product{productCount} to warehouse");
                ShowWarehouse();
                products.CompleteAdding();
            }

        

            private static void TakeProduct()
            {
                string productToTake;
                while (!products.IsCompleted)
                {
                    if (products.TryTake(out productToTake))
                        Console.WriteLine($"Consumer takes a {productToTake} from warehouse");
                    ShowWarehouse();
                }
            }

           


            private static void ShowWarehouse()
            {
                Console.WriteLine("Products:");
                foreach (var product in products)
                    Console.WriteLine(product);
                Console.WriteLine("\n");
            }

       

            public static void TaskMain()
            {
                try
                {
                    productCount = 0;
                    products = new BlockingCollection<string>();

                    Task[] producers = new Task[]
                    {
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct),
                    Task.Factory.StartNew(PutProuct)

                    };
                    Task[] consumers = new Task[]
                    {
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct),
                    Task.Factory.StartNew(TakeProduct)
                    };

                    Task.WaitAll(producers.Concat(consumers).ToArray());
                    foreach (var pr in producers)
                        pr.Dispose();
                    foreach (var con in consumers)
                        con.Dispose();
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("The END");
                }
                Console.WriteLine();
            }


        }
    }
}