using System;
using System.Collections.Generic;
using System.Linq;


namespace Laba11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ограничении длины");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[12] { "January", "Febraury", "March", "April", "May", "June", "Jule", "August", "September", "October", "November", "December" };
            IEnumerable<string> month = from i in str
                                        where i.Length < n
                                        select i;
            foreach (string i in month)
                Console.WriteLine(i);

            Console.WriteLine();
            Console.WriteLine("Зимниие и летние месяцы  года");
            IEnumerable<string> winterorsummer = str
                                                 .Take(2)
                                                 .Concat(str.Skip(5).Take(3))
                                                  .Concat(str.Skip(11).Take(1));
            foreach (string i in winterorsummer)
                Console.WriteLine(i);

            Console.WriteLine();

            Console.WriteLine("Алфавит");
            IEnumerable<string> Alpahibt = str
                                           .OrderBy(i => i);
                                         
            foreach (string i in Alpahibt)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine("Буква u  и месяцы длинной не меньше 4 букв");
            IEnumerable<string> SpecCondition = from i in str
                                                where (i.Contains("u") && i.Length >= 4)
                                                select i;
            foreach (string i in SpecCondition)
                Console.WriteLine(i );
            Console.WriteLine();

            List<Airline> Plane = new List<Airline>();
            Plane.Add(new Airline("Minsk", 123, "Boeing", 2));
            Plane.Add(new Airline("Kair", 789, "Airbus", 3));
            Plane.Add(new Airline("Amsterdam", 054, "Shark", 10));
            Plane.Add(new Airline("New York", 147, "Boeing", 20));
            Console.WriteLine("Пунк назначения: Номер полёта: Название самолёта: Время полёта (час)");
            foreach (string i in SpecCondition)
                Console.WriteLine(i);
            Console.WriteLine();

            Console.WriteLine("Самый долгий полет");
            IEnumerable<Airline> Long_flight = from z in Plane
                                               where z.time > 10     
            select z;
            Console.WriteLine("Пунк назначения: Номер полёта: Название самолёта: Время полёта (час)");
            foreach (Airline i in Long_flight)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine("Расположение по алфавиту");
            IEnumerable<Airline> Aphab = Plane
                                         .OrderBy(i => i.destination);
            Console.WriteLine("Пунк назначения: Номер полёта: Название самолёта: Время полёта (час)");
            foreach (Airline i in Aphab)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Свой запрос:");
            string[] str__1 = { "one", "two", "four" };
            string[] str__2 = { "five", "six", "two" };
            foreach (string x in str__1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (string x in str__2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("Join");
            string[] str_1 = new string[3] { "123", "456", "121" };
            int[] num = new int[3] { 1, 2, 3 };

            var SomeType = str
                .Join(
                num,
                w => w.Length,
                s => s,
                (w, s) => new
                {
                    name = w,
                    month = s
                }
                );
            foreach(var x in SomeType)
            {
                Console.WriteLine(x);
            }
        }
    }
}
