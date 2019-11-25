
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using System.Collections.ObjectModel;


namespace Laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList first = new ArrayList();
            first.Add(1);
            first.Add(2);
            first.Add(3);
            first.Add(4);
            first.Add(5);
            first.Add("String");
            // first.Add(Student);
            first.RemoveAt(3);
            for (int i = 0; i < first.Count; i++)
            {
                Console.WriteLine(first[i] + " - индекс " + i);
                Console.WriteLine("Кол-во : " + first.Count);
            }
            Console.WriteLine(first.LastIndexOf(1));

            Console.WriteLine();
            Console.WriteLine("вторая часть");
            HashSet<long> second = new HashSet<long>();
            second.Add(332434534);
            second.Add(3324345343453454);
            second.Add(33243453445334);
            second.Add(332434534243);
            Console.WriteLine("вывод");
            foreach (long value in second)
            {
                Console.WriteLine(value);

            }
            second.Remove(2);
            foreach (long value in second)
            {
                Console.WriteLine(value);

            }
            Console.WriteLine();
            SortedSet<long> third = new SortedSet<long>();
            third.UnionWith(second);
                foreach (long ch in third)
                Console.Write(ch + "\n");

            Console.WriteLine(  third.Contains(332434534243));

            Console.WriteLine(" Пользовательский тип");
            Console.WriteLine();
            HashSet<Animals> fifth = new HashSet<Animals>();
            fifth.Add(332434534);
            fifth.Add(3324345343453454);
            fifth.Add(33243453445334);
            fifth.Add();
            Console.WriteLine("вывод");
            foreach (long value in fifth)
            {
                Console.WriteLine(value);

            }
            fifth.Remove(2);
            foreach (long value in fifth)
            {
                Console.WriteLine(value);

            }
            Console.WriteLine();
            SortedSet<Animals> six = new SortedSet<Animals>();
            six.UnionWith(fifth);
            foreach (Animals ch in six)
                Console.Write(ch + "\n");

            Console.WriteLine(six.Contains(332434534243));

            Console.WriteLine();
            Console.WriteLine("Наблюдаемая коллекция");
            ObservableCollection<Animals> observ = new ObservableCollection<Animals>();
            observ.CollectionChanged += StaticClass.method;
        }
    }
}
