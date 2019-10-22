using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAba5
{
    sealed class Crocodile
    {
        readonly string Name = "Croki";
        readonly string Kind = "Reptile";
        readonly string Habitat = "Tropics";
    }
      interface ISound
    {
        void Sound();
    }
    abstract public  class Animals 
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
    public class Fish : Animals
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
            return  this.Habitat;
            
        }
    }


    public class Lion : Mammial, ISound
    {
    
       
        public override void Name()
        {
            Console.WriteLine("Leo");
        }
        public void Sound()
        {
            Console.WriteLine("Рррррр");
        }

    }
    public class Tigr : Mammial
    {
    
        public override void Name()
        {
            Console.WriteLine("Tigra");
        }
        public void Sound()
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
        public void Sound()
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
        public void Sound()
        {
            Console.WriteLine("Привет, я попугай Кеша");
        }
    }
    public class Shark : Fish
    {
      
        public override void Name()
        {
            
            Console.WriteLine("Nemo");
        }
        public void Sound()
        {
            Console.WriteLine("ООООО");
        }
    }
    

    class Program
    {
       
        static void Main(string[] args)

        {
            Mammial[] mammials = new Mammial[2];
            Lion Lion = new Lion();
            Lion.Kind_of_animal = "Mammial";
            Lion.Habitat = "Savanna";
            Tigr Tigra = new Tigr();
            Tigra.Kind_of_animal = "Mammial";
            Tigra.Habitat = "Savanna";
            mammials[0] = Lion;
            mammials[1] = Tigra;
            for (int i = 0; i < mammials.Length; i++)
            {
                mammials[i].Name();
                Console.WriteLine(mammials[i].Kind_of_animal);
                Console.WriteLine(mammials[i].Habitat);
             //  Console.WriteLine(mammials[i].ISound);
            }
            ///
            Fish fish = new Fish();
            fish.Kind_of_animal = "Fish";
            fish.Habitat = "Ocean";
            //
            fish.Name();
            Console.WriteLine(fish.Kind_of_animal);
            Console.WriteLine(fish.Habitat);
           // Console.WriteLine(fish.ISound);
            Console.WriteLine(mammials.ToString());
            Console.WriteLine(fish.ToString());
        }
    }
}
