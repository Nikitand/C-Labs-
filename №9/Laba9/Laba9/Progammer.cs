
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{

    delegate int summa(int x, int y, int z);
    delegate void priv();
    class ProgCont
    { 
            public event EventHandler Rename;
            public event EventHandler New_property;
            public void Run()
            {
            Console.WriteLine( "Run");
            if (Rename != null)
                Rename(this, null);
            New_property?.Invoke(this, null);
            }

    }
    class Language
    {
       
            static int count = 0;
             public int Property;  
            public string Name;


            public Language()
            {
                Name = "C# " ;
                Property = 15;
                count++;
            }

            public Language(int lv)
            {
                Name = "Jav ";
                Property = lv;
                count++;
            }

            public Language(int vl, string nam)
            {
                Name = nam ;
                Property = vl;
                count++;
            }

            ~Language()
            {
                count--;
            }

            public void Newname(object sender, EventArgs e)
            {
            int i = 0;
            Console.WriteLine("Язык " +  Name + "\n Если название верно нажми 1, если нет нажми 0");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            { return; }
            else if (i == 0)
            {
                Console.WriteLine("Введите правильное имя языка");
                Name = Console.ReadLine();
               
            }
            }

            public void change(object sender, EventArgs e)
            {
            
            if (Property > 5)
            {
                Console.WriteLine(Name +  " Добавляем  свойства");
                Property--;
            }
            else {
                Console.WriteLine(Name + " Удаляем свойство");
                Property++;
            }
            }
        
    }
}
