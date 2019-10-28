using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAba5
{
   
    interface ISound
    {
        void Sound();
    }
    interface Iinter
    {
        string ToString();
    }

   

    public abstract partial class Animals: Base
        { 


        public virtual string Kind_of_animal { get; set; } // Вид животного
        public string Habitat;
        public void str()
        {
            Habitat = null;
        }
       public  int Age;

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
    }
    // Бесплоный класс
    sealed class Crocodile : Animals, ISound, Iinter
    {
        readonly string Name = "Croki";
        readonly string Kind = "Reptile";
        private new readonly string Habitat = "Tropics";


        public override void Sound()
        {
            Console.WriteLine("Араррараарар");
        }
        void ISound.Sound()
        {
            Console.WriteLine(" Реализация функции интерфейса");
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

        public class Shark : Fish, Iinter
        {

            public override void Name()
            {

                Console.WriteLine("Nemo");
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
                Lion Lion = new Lion();
                Lion.Kind_of_animal = "Mammial";
                Lion.Habitat = "Savanna";
                Tigr Tigra = new Tigr();
                Tigra.Kind_of_animal = "Mammial";
                Tigra.Habitat = "Savanna";
                mammials[0] = Lion;
                mammials[1] = Tigra;
                Fish fish = new Fish()
                {
                    Kind_of_animal = "Fish",
                    Habitat = "Ocean"
                };
                Crocodile croky = new Crocodile();
                ISound sou = croky;
                Console.WriteLine("Croky");
                Console.Write("Голос:");

                croky.Sound();
                zoo.Add(Lion);
                zoo.Add(Tigra);
                zoo.Add(fish);
                zoo.Add(croky);
                zoo.show();
                controller.show(zoo);
                controller.sort(zoo);

                ///


                //////
           


                ////////
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
}