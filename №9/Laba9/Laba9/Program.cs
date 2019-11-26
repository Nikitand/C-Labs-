using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            void show(Language[] array)
            {
                Console.WriteLine("Language:");
                foreach (Language x in array)
                {
                    Console.Write($"{x.Name} -- ");
                    Console.WriteLine($"Свойство: {x.Property}");
                }
                Console.WriteLine();
            }

            ProgCont contr = new ProgCont();
            Language[] norm = new Language[4];
            norm[0] = new Language();
            norm[1] = new Language(5);
            norm[2] = new Language(3,"C++");
            norm[3] = new Language(4,"Python");



            show(norm);
            contr.Rename += norm[1].Newname;
            contr.Run();
            show(norm);
            contr.Rename += norm[2].Newname;
            contr.New_property += norm[2].change;  
            contr.New_property += norm[0].change;
            contr.Run();
            show(norm);
        
            priv hi = () => Console.WriteLine("Hello, it's delegates");
            summa summ = (x, y, z) => z < 10 ? x + y : x * y;
            hi();
            Console.WriteLine(summ(4, 3, 12));

            StringBuilder str = new StringBuilder("KSFV F S.eA Po");
            Action<StringBuilder> action;
            action =  Operation.AddBAfterS;
            action += Operation.DeleteSpaces;
            action += Operation.AddSpacesAfterPoints;
            action += Operation.DeleteCommas;
            action += Operation.DeleteLetterA;

            action(str);
            Console.WriteLine($"{str}\n");
        }
    }
}
