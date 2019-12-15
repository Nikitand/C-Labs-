using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class Animals
    {
        public string Habitat;
        public string name;
        public Animals(string H, string N)
        {
            Habitat = H;
            name = N;
        }
        public Animals()
        {
        }
        public virtual void Show()
        {
            Console.WriteLine($"Название :  {name } Место обитания : {Habitat}  ");
        }
    }
    [Serializable]
    public class Predator : Animals

    {
        [NonSerialized]
        public int age;

        public Predator(string H, string N, int age) : base(H, N)
        {
            this.age = age;
        }
        public string predator = "Это хищник";
        public Predator()
        {
        }
        public override void Show()
        {
            Console.WriteLine($"{predator}\n Название :  {name } Место обитания : {Habitat} Возраст: {age} ");
        }

    }
}
         