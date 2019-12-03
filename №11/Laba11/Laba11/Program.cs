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
            Console.WriteLine();
            Console.WriteLine("Ограничение длины месяца");
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
                Console.WriteLine(i);
            Console.WriteLine();

            List<Airline> Plane = new List<Airline>();
            Plane.Add(new Airline("Minsk", 123, "Boeing", 1));
            Plane.Add(new Airline("Kair", 789, "Airbus", 2));
            Plane.Add(new Airline("Amsterdam", 054, "Shark", 20));
            Plane.Add(new Airline("New York", 147, "Boeing", 8));
            Console.WriteLine();
            Console.WriteLine("           Пунк назначения: Номер полёта: Название самолёта: Время полёта (час)");
            foreach (Airline i in Plane)
                Console.WriteLine(i);
            Console.WriteLine();

            Console.WriteLine("Самый долгий полет");
            Console.WriteLine();
            IEnumerable<Airline> Long_flight = from z in Plane
                                               where z.time > 10
                                               select z;
            Console.WriteLine("           Пунк назначения: Номер полёта: Название самолёта: Время полёта (час)");
            foreach (Airline i in Long_flight)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine("Расположение по алфавиту");
            IEnumerable<Airline> Aphab = Plane
                                         .OrderBy(i => i.destination);
            Console.WriteLine("           Пунк назначения: Номер полёта: Название самолёта: Время полёта (час)");
            foreach (Airline i in Aphab)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine("Расположение по времени полёта");
            IEnumerable<Airline> Time = Plane
                                         .OrderBy(i => i.time);
            Console.WriteLine("           Пунк назначения: Номер полёта: Название самолёта: Время полёта (час)");
            foreach (Airline i in Time)
                Console.WriteLine(i);
            Console.WriteLine();
            Console.WriteLine("Пункт назначения:Минск");
            IEnumerable<Airline> minsk = from q in Plane
                                         where q.destination == "Minsk"
                                         select q;
            Console.WriteLine("           Пунк назначения: Номер полёта: Название самолёта: Время полёта (час)");
            foreach (Airline f in minsk)
                Console.WriteLine(f);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Свой запрос:");
            string[] str__1 = { "One", "two", "four", "five", "seven", "orange" };
            //  string[] str__2 = { "1", "4", "2" };
            foreach (string x in str__1)
            {
                Console.Write("  " + x);
            }
            Console.WriteLine();
            Console.WriteLine("Упорядочить по алфовиту:");
            IEnumerable<string> A0 = str__1
                                      .OrderBy(s => s);
            foreach (string x in A0)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            Console.WriteLine("Условие и квантование");
            IEnumerable<string> A1 = from i in str__1
                                     where (i.Contains("o") && i.Length >= 4)
                                     select i;
            foreach (string x in A1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Разбиения");
            IEnumerable<string> A2 = str__1
                                     .Skip(3)
                                     .Take(2);

            foreach (string x in A2)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();
            Console.WriteLine("Join");
            string[] str_1 = new string[3] { "123", "456", "121" };
            int[] num = new int[3] { 1, 2, 3 };

            var SomeType = str_1
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
            foreach (var x in SomeType)
            {
                Console.WriteLine(x);
            }
        }
    }

  
}

