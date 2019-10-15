using System;
using System.Collections;
using System.Collections.Generic;

namespace Laba4
{ 
    // Статические класс
    //  Математически операции
    public static class MathOperation
    {
        public static int GetCount(Queue queue_2)
        {
            int count = 0;
            foreach (int i in queue_2)
                count++;
            return count;
        }
        public static int GetMax(Queue queue_2)
        {
            int max = 0;
            foreach (int i in queue_2)
            {
                if (i > max)
                    max = i;

            }
            return max;
            
        }
        public static int GetMin(Queue queue_2)
        {
            int min = 0;
            foreach (int i in queue_2)
            {
                if (i < min)
                    min = i;
            }
            return min;

        }
        public static int Sum(Queue queue_2)
        {
            int sum = 0;
            foreach (int i in queue_2)
            {
                sum += i;

            }
            return sum;

        }
    }
    public static class extensions
    {
        public static int Lastelem(this int queue_1,  int tail)
        {
           return tail;
        }
    }
    class Program
    { // Владелец
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
        public class Queue
        {
            public int[] dataarr; // данные
            public int head;//голова
            public int tail;// хвост
            int count;
            private static DateTime info;

            Queue(int numbers)
            {
                dataarr = new int[3];
                head = 0;
                tail = 0;

            }
            public void Enqueue(int item)// добавление
            {
                dataarr[tail] = item;
                tail++;
                count++;
            }
            public int Dequeue(int a)// извлечение
            {
                a = dataarr[head];
                head++;
                return a;
                count--;
            }



            public readonly Owner owner = new Owner();

            // Перегрузка операций
            //////////////////
            public static Queue operator +(Queue q1, int q2)
            {
                q1.Enqueue(q2);
                return q1;
            }
            ///////////////////
            public static Queue operator -(Queue q1, int q2)
            {
                q1.Enqueue(q2);
                return q1;
            }
            ///////////////////
            public static bool operator true(Queue q1)
            {
                return q1.head == q1.tail;
            }
            ////////////////////
            public static bool operator false(Queue q1)
            {
                return q1.head != q1.tail;
            }
            ////////////////////
            public static Queue operator >(Queue q1, Queue q2)
            {
                for (int i = 0; i < q1.count; i++)
                {
                    q2.dataarr[i] = q1.dataarr[i];
                }
                return q2;
            }
            public static Queue operator <(Queue q1, Queue q2)
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
        
           
        
            static void Main(string[] args)
            {
                Queue queue_1 = new Queue(3);
                Queue queue_2 = new Queue(2);
                queue_1.Enqueue(5);
                queue_1 = queue_1 + 2;
                queue_1 = queue_1 + 1;
                Console.WriteLine("Очередь №1");
                foreach (int i in queue_1.dataarr)
                    Console.WriteLine(i);
                Console.WriteLine("Очередь №2 до");
                foreach (int i in queue_2.dataarr)
                    Console.WriteLine(i);
                queue_2 = queue_1 > queue_2;
                Console.WriteLine("Очередь №2 после");
                foreach (int i in queue_2.dataarr)
                 Console.WriteLine(i);
                info = DateTime.Now;
                Console.WriteLine(info);
                Console.WriteLine("Name: "+queue_1.owner.Name);
                Console.WriteLine("ID: "+queue_1.owner.ID);
                Console.WriteLine("Univer: " + queue_1.owner.Univer);
            }

            
        }
    }
}

