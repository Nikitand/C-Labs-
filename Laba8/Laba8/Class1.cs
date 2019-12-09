using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8
{
    public class Animals
    {


        public virtual string Kind_of_animal { get; set; } // Вид животного
        public string Habitat { get; set; }
        void Getinfo()
        {
            Console.WriteLine("Пользовательский класс");
        }

        public override string ToString()
        {
            return "Пользовательский класс";
        }
    }
}
