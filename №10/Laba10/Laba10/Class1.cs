using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    interface ISound
    {
        void Sound();
    }
    interface Iinter
    {
        string ToString();
    }
    abstract public class Animals
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
    }
}
