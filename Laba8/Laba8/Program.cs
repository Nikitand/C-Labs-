using System;
using System.Collections;

namespace Laba8
{
    // Статические класс
    //  Математически операции

    //public static class MathOperation
    //{
    //    public static int GetCount(Queue queue_2)
    //    {
    //        int count = 0;
    //        foreach (int i in queue_2)
    //            count++;
    //        return count;
    //    }
    //    public static int GetMax(Queue queue_2)
    //    {
    //        int max = 0;
    //        foreach (int i in queue_2)
    //        {
    //            if (i > max)
    //                max = i;

    //        }
    //        return max;

    //    }
    //    public static int GetMin(Queue queue_2)
    //    {
    //        int min = 0;
    //        foreach (int i in queue_2)
    //        {
    //            if (i < min)
    //                min = i;
    //        }
    //        return min;

    //    }
    //    public static int Sum(Queue queue_2)
    //    {
    //        int sum = 0;
    //        foreach (int i in queue_2)
    //        {
    //            sum += i;

    //        }
    //        return sum;

    //    }
    //}
    public interface IObInterface<T>
    {
        void add(T obj);
        T del(T obj);
        void show();

    }
    public static class extensions
    {
        public static int Lastelem(this int queue_1, int tail)
        {
            return tail;
        }
    }
  
        // Владелец
        public class Owner
        {
            public string ID { get; } = "11111111";
            public string Name { get; } = "Nikita";
            public string Univer { get; } = "BSTU";
        }
        // Дата
        class DATA
        {
            public DateTime info;

        }

   
    // Очередь
    public class Queue<T> : IObInterface<T> where T : struct
    {
        public T[] dataarr; // данные
        public int head;//голова
        public int tail;// хвост
        int count;
        private static DateTime info;

        public Queue(int numbers)
        {
            dataarr = new T[3];
            head = 0;
            tail = 0;

        }
        public void add(T item)// добавление
        {
            
            dataarr[tail] = (T)item;
            tail++;
            count++;
        }
        public T del(T a)// извлечение\удаление
        {
            if (count == 0)
            {
                throw new Exception_size("Очередь пуста. Удаление не возможно");
            }
            a = dataarr[head];
            head++;
            return a;
            count--;
        }
        public void show()// вывод
        {
            foreach (T i in dataarr)
            {
                Console.WriteLine(i);
            }
        }


        public readonly Owner owner = new Owner();

        // Перегрузка операций
        //////////////////
        public static Queue<T> operator +(Queue<T> q1, T q2)
        {
            q1.add(q2);
            return q1;
        }
        ///////////////////
        public static Queue<T> operator -(Queue<T> q1, T q2)
        {
            q1.del(q2);
            return q1;
        }
        ///////////////////
        public static bool operator true(Queue<T> q1)
        {
            return q1.head == q1.tail;
        }
        ////////////////////
        public static bool operator false(Queue<T> q1)
        {
            return q1.head != q1.tail;
        }
        ////////////////////
        public static Queue<T> operator >(Queue<T> q1, Queue<T> q2)
        {
            for (int i = 0; i < q1.count; i++)
            {
                q2.dataarr[i] = q1.dataarr[i];
            }
            return q2;
        }
        public static Queue<T> operator <(Queue<T> q1, Queue<T> q2)
        {

            return q2;
        }
        ///////////////
        public int Count { get { return count; } }

        public void Clear()
        {
            head = 0;
            tail = 0;
            count = 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Queue<int> queue_1 = new Queue<int>(3);
                queue_1.add(4);
                queue_1.add(7);
                queue_1 = queue_1 + 2;
                //Queue<string> queue_2 = new Queue<string>(2);
                //queue_2.add("first");
                //queue_2.add("second");
                //queue_2.show();
                Queue<bool> queue_3 = new Queue<bool>(2);
                queue_3.add(true);
                queue_3.add(false);
                queue_3.show();
                // exception_1
                //queue_1 = queue_1 + 2;

                Console.WriteLine("Name: " + queue_1.owner.Name);
                Console.WriteLine("ID: " + queue_1.owner.ID);
                Console.WriteLine("Univer: " + queue_1.owner.Univer);
                queue_1.show();
                // exception_2
               // queue_1.Clear();
               // queue_1.del(4);
               
            }
            catch (Exception_size ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Конец программы");
            }

            //    queue_1.Enqueue(5);
            //    queue_1 = queue_1 + 2;
            //    queue_1 = queue_1 + 1;
            //    Console.WriteLine("Очередь №1");
            //    foreach (int i in queue_1.dataarr)
            //        Console.WriteLine(i);
            //    Console.WriteLine("Очередь №2 до");
            //    foreach (int i in queue_2.dataarr)
            //        Console.WriteLine(i);
            //    queue_2 = queue_1 > queue_2;
            //    Console.WriteLine("Очередь №2 после");
            //    foreach (int i in queue_2.dataarr)
            //        Console.WriteLine(i);
            //    info = DateTime.Now;
            //    Console.WriteLine(info);

        }

    }
}


