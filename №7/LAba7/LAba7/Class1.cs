using System;

using System.Diagnostics;

namespace Laba7
{
    public abstract partial class Animals
    {
        public Animals(int age, int weight)
        {

            info.Age = age;
            info.Weight = weight;

        }
    }


    enum list
    {
        first = 1,
        second,
        third,
        fourth,
        fifth
    }

    public class ZOO
    {
        public Base[] an;
        public int count = 0;
        public int size;
        list list = new list();

        public ZOO()
        {
            size = 5;
            an = new Base[6];
        }

        public bool isFull()
        {
            return (count == size);
        }

        public bool isEmpty()
        {
            return (count == 0);
        }

        public void Add(Base el)
        {
            if (isFull())
             throw new Exception_IsFull("Полный");
            an[count++] = el;
        }

        public void Del(Base el)
        {
            int num = 0;
            if (isEmpty())
                return;
            for (int i = 0; i < count; i++)
            {
                if (an[i].Equals(el))
                    num = i;
            }
            for (int i = num; i < count; i++)
            {
                an[i] = an[i + 1];
            }
            count--;
        }

        public void show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(an[i].ToString());
            }
            Console.WriteLine();
            ;
        }
    }


    public abstract class Base
    {
        public struct Info
        {
            public int Age;
            public int Weight;

        }
        public Info info = new Info();
    }

    public static class controller
    {


       

        public static void sort(ZOO animal)
        {
            Base elem;
            for (int i = 0; i < animal.count - 1; i++)
            {
                for (int j = 0; j < animal.count - i - 1; j++)
                {
                    if (animal.an[j].info.Age < animal.an[j + 1].info.Age)
                    {
                        elem = animal.an[j];
                        animal.an[j] = animal.an[j + 1];
                        animal.an[j + 1] = elem;
                    }
                }
            }
        }

        public static void show(ZOO animal)
        {


            string[] Kind = new string[6];
            int[] Age = new int[6];
            int[] Weight = new int[6];
            int[] count = new int[7];
            int pos = 0;
            bool b = false;

            for (int j = 0; j < animal.count; j++)
            {
                for (int i = 0; i < pos; i++)
                {
                    if (Kind[i] == (animal.an[j].GetType()).Name)
                    {
                        b = true;
                        count[i]++;
                        break;
                    }
                }
                if (!b )
                {
                    Kind[pos] = animal.an[j].GetType().Name;
                    Age[pos] = animal.an[j].info.Age;
                    Weight[pos] = animal.an[j].info.Weight;
                    count[pos]++;
                    pos++;
                }
               // Debug.Assert(b == true, "ERROR");
                b = false;
                
            }

            Console.WriteLine("Info:");
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine($" Вид {Kind[i]} - Год рождения: {Age[i]} - Вес: {Weight[i]}Кг ");
            }
            Console.WriteLine();
        }
    }
}