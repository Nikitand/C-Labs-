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

     public class Animals : IComparable
    {


        public virtual string Kind_of_animal { get; set; } // Вид животного
        public int Age;
        public void str()
        {
           
        }

        public override string ToString()
        {
            return this.Kind_of_animal + this.Age;
        }
        void Animal()
        {
            Age = 15;

        }
        public int CompareTo(object obj)
        {
            return Age;
        }


    }

    public class Mammial : Animals
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
        
    }
    // Бесплоный класс
    sealed class Crocodile : Animals, ISound, Iinter
    {
        readonly string Name = "Croki";
        readonly string Kind = "Reptile";
        private new readonly string Habitat = "Tropics";


       
        void ISound.Sound()
        {
            Console.WriteLine(" Реализация функции интерфейса");
        }
    }


    public class Lion : Mammial,  Iinter
    {


        public override void Name()
        {
            Console.WriteLine("Leo");
        }
        

    }
    public class Tigr : Mammial,  Iinter
    {

        public override void Name()
        {
            Console.WriteLine("Tigra");
        }
       
    }
    public class Owl : Birds
    {

        public override void Name()
        {
            Console.WriteLine("Sova");
        }
       
    }
    public class Parrot : Birds
    {

        public override void Name()
        {
            Console.WriteLine("Kesha");
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
