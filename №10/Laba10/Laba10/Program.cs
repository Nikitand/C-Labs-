
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
                //
            }
            Console.WriteLine("Кол-во : " + first.Count);
            Console.WriteLine(first.LastIndexOf(1));

            Console.WriteLine();
            Console.WriteLine("вторая часть");
            HashSet<long> second = new HashSet<long>()
            {
                 4545, 65646, 512
            };
            Console.WriteLine("вывод");
            foreach (long value in second)
            {
                Console.WriteLine(value);

            }
            Console.Write("Udalenie");
            ///разобраться
            second.Remove(1);
            Console.WriteLine();
            foreach (long value in second)
            {
                Console.WriteLine(value);

            }
            Console.WriteLine("Sorted SET");
            SortedSet<long> third = new SortedSet<long>();
            third.UnionWith(second);
            foreach (long ch in third)
                Console.Write(ch + "\n");

            Console.WriteLine(third.Contains(332434534243));

            Console.WriteLine(" Пользовательский тип");
            Console.WriteLine();
            
            HashSet<Animals> fifth = new HashSet<Animals>();
            fifth.Add(new Animals("Lion"));
            fifth.Add(new Animals("Owl"));
            fifth.Add(new Animals("Shark"));
            Console.WriteLine("Вывод работы со зверьми");
            foreach (Animals value in fifth)
            {
                Console.WriteLine(value);

            }
            Console.WriteLine();
            SortedSet<Animals> six = new SortedSet<Animals>();
            six.UnionWith(fifth);
            Console.WriteLine("Новый");
            foreach (Animals ch in fifth)
               Console.Write(ch + "\n");
            Console.WriteLine();
            Console.WriteLine(six.Contains( new Animals("Shark")));
            Console.WriteLine();
            Console.WriteLine("Наблюдаемая коллекция");
            ObservableCollection<Animals> observ = new ObservableCollection<Animals>();
            observ.CollectionChanged += StaticClass.method;

           
        }
    }
}
