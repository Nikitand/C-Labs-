using System;


namespace Laba7
{

    interface ISound
    {
        void Sound();
    }
    interface Iinter
    {
        string ToString();
    }



    public abstract partial class Animals : Base
    {
        public virtual string Kind_of_animal { get; set; } // Вид животного
        public string Habitat;
        public void str()
        {
            Habitat = null;
        }


        public override string ToString()
        {
            return this.Kind_of_animal + this.Habitat;
        }

        abstract public void Sound();
    }

    public class Mammial : Animals, ISound
    {
        public override string Kind_of_animal
        {
            get => base.Kind_of_animal;
            set => base.Kind_of_animal = value;
        }
        public virtual void Name()
        {
        }
        public override string ToString()
        {
            return this.Kind_of_animal;
        }

        public override void Sound()
        {

        }
        public Mammial(int age, int weight) : base(age, weight)
        {
            if (weight < 0)
            {
                throw new Exception_weight("Вес меньше 0");
            }
        }

    }
    public class Birds : Animals
    {
        public override string Kind_of_animal
        {
            get => base.Kind_of_animal;
            set => base.Kind_of_animal = value;
        }
        public virtual void Name()
        {
        }
        public override string ToString()
        {
            return this.Kind_of_animal;
        }
        public override void Sound()
        {

        }
        public Birds(int age, int weight) : base(age, weight)
        {
            if (weight < 0)
            {
                throw new Exception_weight("Вес меньше 0");
            }

        }
    }
    public class Fish : Animals, Iinter
    {
        public override string Kind_of_animal
        {
            get => base.Kind_of_animal;
            set => base.Kind_of_animal = value;
        }
        public virtual void Name()
        {
        }
        public override string ToString()
        {
            return this.Habitat;

        }
        public override void Sound()
        {

        }
        public Fish() : base(2018, 10)
        {

        }
        public Fish(int age, int weight) : base(age, weight)
        {
            if (weight < 0)
            {
                throw new Exception_weight("Вес меньше 0");
            }
        }
    }
    // Бесплоный класс
    sealed class Crocodile : Animals, ISound, Iinter
    {
        readonly string Name = "Croki";
        readonly string Kind = "Reptile";
        private new readonly string Habitat = "Tropics";


        public override void Sound()
        {
            // Console.WriteLine("Араррараарар");
        }
        void ISound.Sound()
        {
            Console.WriteLine(" Реализация функции интерфейса");
        }
        public Crocodile() : base(-2010, 250)
        {

        }
        public Crocodile(int age, int weight) : base(age, weight)
        {
            if (weight < 0)
            {
                throw new Exception_weight("Вес меньше 0");
            }
            if (age < 0)
            {
                throw new Exception_age("Возраст меньше 0");
            }
        }
    }


    public class Lion : Mammial, ISound, Iinter
    {


        public override void Name()
        {
            Console.WriteLine("Leo");
        }
        public override void Sound()
        {
            Console.WriteLine("Рррррр");

        }
        public Lion(int age, int weight) : base(age, weight)
        {
            if (weight < 0)
            {
                throw new Exception_weight("Вес меньше 0");
            }
            if (age < 0)
            {
                throw new Exception_age("Возраст меньше 0");
            }
        }
    }
    public class Tigr : Mammial, ISound, Iinter
    {

        public override void Name()
        {
            Console.WriteLine("Tigra");
        }
        public override void Sound()
        {
            Console.WriteLine("Рррррр");
        }
        public Tigr(int age, int weight) : base(age, weight)
        {
            if (weight < 0)
            {
                throw new Exception_weight("Вес меньше 0");
            }
            if (age < 0)
            {
                throw new Exception_age("Возраст меньше 0");
            }
        }
    }
    public class Owl : Birds, ISound
    {

        public override void Name()
        {
            Console.WriteLine("Sova");
        }
        public override void Sound()
        {
            Console.WriteLine("Оу Оу");
        }
        public Owl(int age, int weight) : base(age, weight)
        {
            if (weight < 0)
            {
                throw new Exception_weight("Вес меньше 0");
            }
        }

        
    }
    public class Parrot : Birds
    {

        public override void Name()
        {
            Console.WriteLine("Kesha");
        }
        public override void Sound()
        {
            Console.WriteLine("Привет, я попугай Кеша");
        }
        public Parrot(int age, int weight) : base(age, weight)
        {
            if (weight < 0)
            {
                throw new Exception_weight("Вес меньше 0");
            }
        }
    }

    public class Shark : Fish, Iinter
    {

        public override void Name()
        {

            Console.WriteLine("Nemo");
        }
        public Shark(int age, int weight) : base(age, weight)
        {
            if (weight < 0)
            {
                throw new Exception_weight("Вес меньше 0");
            }
        }
    }

    // /print

    class Print
    {
        public static void IAmPrinting(Iinter obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }


    class Program
    {

        static void Main(string[] args)

        {
            //int a = 8;
            ZOO zoo = new ZOO();
            
                Mammial[] mammials = new Mammial[2];
                Lion Lion = new Lion(2015, 64);
                //Lion.Kind_of_animal = "Mammial";
                //Lion.Habitat = "Savanna";
                Tigr Tigra = new Tigr(2014, 65);
            //  Tigra.Kind_of_animal = "Mammial";
            //Tigra.Habitat = "Savanna";

            try
            {
                Birds[] birds = new Birds[2];
            }
            catch (Exception_weight ex)
            { Console.WriteLine("Ошибка: " + ex.Message); }
                Parrot parrot = new Parrot(2017, 2);
                Owl owls = new Owl(2015, -4);
                Fish fish = new Fish(2019, 1);
            try
            {
                Crocodile croky = new Crocodile();
                croky.Sound();

                zoo.Add(Lion);
                zoo.Add(Tigra);
                zoo.Add(fish);
                zoo.Add(croky);
                zoo.Add(owls);
                zoo.Add(parrot);
                //zoo.show();
                controller.show(zoo);
                controller.sort(zoo);
                Console.WriteLine("Sortirovka");
                controller.show(zoo);
                zoo.show();
            }

            catch (Exception_IsFull ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception_weight ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception_age ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            /////
            //Console.WriteLine();
            //Console.WriteLine(mammials.ToString());
            //Console.WriteLine(fish.ToString());
            //Console.WriteLine();
            ////     is/as
            //bool value = Lion is int;
            //Console.WriteLine(value);
            //Console.WriteLine(a as Object);
            //  
            //Console.WriteLine();
            //foreach (Iinter x in arr)
            //{
            //    Print.IAmPrinting(x);
            //}
        }
    }
}
