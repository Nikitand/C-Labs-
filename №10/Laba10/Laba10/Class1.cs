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
        public int Habitat;
        public string name;
        public void str()
        {
           
        }
        public override string ToString()
        {
            return this.name;
                
        }

      
        public int CompareTo(object obj)
        {
            return Habitat;
        }
        public Animals(string str)
        {
            name = str;
        }

    }

    public class Mammial : Animals
    {
        public override string Kind_of_animal
        {
            get => base.Kind_of_animal;
            set => base.Kind_of_animal = value;
        }
        public Mammial(string str) : base(str)
        { }

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
        public Birds(string str) : base(str)
        { }
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
        public Fish(string str) : base(str)
        { }

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
        public Crocodile(string str) : base(str)
        { }
    }


    public class Lion : Mammial,  Iinter
    {


        public override void Name()
        {
            Console.WriteLine("Leo");
        }
        public Lion(string str) : base(str)
        { }


    }
    public class Tigr : Mammial,  Iinter
    {

        public override void Name()
        {
            Console.WriteLine("Tigra");
        }
        public Tigr(string str) : base(str)
        { }

    }
    public class Owl : Birds
    {

        public Owl(string str) : base(str)
        { }

    }
    public class Parrot : Birds
    {
        public Parrot(string str) : base(str)
        { }
    }


        public class Shark : Fish, Iinter
        {
        public Shark(string str) : base(str)
        { }

    }
    }

