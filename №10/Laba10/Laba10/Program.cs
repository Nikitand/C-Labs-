
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
            Student student = new Student("name", "2");
            //Animals animals = new Animals();
            ArrayList first = new ArrayList(8)
            {
                1, 2, 3, 4, 5
             };
            first.Add("String");
             first.Add(student);
            first.RemoveAt(3);
            for (int i = 0; i < first.Count; i++)
            {
                Console.WriteLine(first[i] + " - индекс " + i);
                Console.WriteLine("Кол-во : " + first.Count);
            }
            Console.WriteLine(first.LastIndexOf(1));

            Console.WriteLine();
            Console.WriteLine("вторая часть");
            HashSet<long> second = new HashSet<long>()
            {
                1234, 4545, 65646
            };
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

            fifth.Add(new Animals());
            fifth.Add(new Animals());
            fifth.Add(new Animals());
        
            Console.WriteLine("вывод");
            foreach (Animals value in fifth)
            {
                Console.WriteLine(value);

            }
            
            
            Console.WriteLine();
            SortedSet<Animals> six = new SortedSet<Animals>();
            six.UnionWith(fifth);
            foreach (Animals ch in six)
                Console.Write(ch + "\n");

            Console.WriteLine(six.Contains(new Animals()));

            Console.WriteLine();
            Console.WriteLine("Наблюдаемая коллекция");
            ObservableCollection<Animals> observ = new ObservableCollection<Animals>();
            observ.CollectionChanged += StaticClass.method;
        }
    }
}
