using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
       
            public class Queue
        {
            public Queue(int data)
            {
                Data = data;
            }
            public int Data { get; set; }
            public Queue<int> Next { get; set; }
       
  



            Queue head; // first element 
            Queue tail; // lasat element
            int count;
            public readonly Owner owner = new Owner();
            public DateTime Showdate() => DateNow.date;
            private class DateNow
            {
                public static DateTime date = DateTime.Now;
            }
            public void Enqueue(int data)
            {
                Queue<int> a = new Queue<int>(data);
                Queue<int> tempQueue = tail;
                tail = a;

                if (count == 0)
                    head = tail;
                else
                    tempQueue.next = tail;
                count++;
            }
            public int Dequeue()
            {
                //if (count == 0)
                //       throw new InvalidOperationException();
                int output = head.Data;
                head = head.next;
                count--;
                return output;
            }
            public int last
            {
                get
                {
                    //if (IsEmpty)
                    //   throw new InvalidOperationException();
                    return tail.Data;
                }
            }
            public int Count { get { return count; } }
            public bool IsEmpty { get { return count == 0; } }
            public void Clear()
            {
                head = null;
                tail = null;
                count = 0;
            }

            public class Owner
            {
                public string ID { get; } = "11111111";
                public string Name { get; } = "Nikita";
                public string Univer { get; } = "BSTU";
            }

            static void Main(string[] args)
            {
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(5);
                queue.Enqueue(4);
                queue.Enqueue(10);
                queue.Enqueue(15);
                queue.Enqueue(2);
                foreach (int item in queue)
                    Console.WriteLine(item);
                int firstItem = queue.Dequeue();
                Console.WriteLine($"Извлеченный элемент очереди: {firstItem}");
            }
        }
    }
}

