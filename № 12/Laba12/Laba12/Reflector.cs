using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Laba12
{
    class Reflector
    {
        static Type GetType(string str)
        {
            return Type.GetType(str);
        }
        public static void WriteTofile(string Class)
        {
            //    запись 
              string Writepath  = @"D:\универ\3 сем\ООп\Лабы\№ 12\Laba12\Type.txt";
              StreamWriter write = new StreamWriter(Writepath);
            Type type_1 = GetType(Class);
            write.WriteLine("Класс ");
            write.WriteLine(type_1.Name);
            write.WriteLine("Конструкторы: ");
            write.WriteLine(type_1.GetConstructors());
            foreach (var x in type_1.GetConstructors())
            {
                write.WriteLine(x);
            }
            write.WriteLine("Методы: ");
            write.WriteLine(type_1.GetMethods());
            foreach (var x in type_1.GetMethods())
            {
                write.WriteLine(x);
            }
            write.WriteLine("Поля: ");
            write.WriteLine(type_1.GetFields());
            foreach (var x in type_1.GetFields())
            {
                write.WriteLine(x);
            }
            write.WriteLine("Ссвойства: ");
            write.WriteLine(type_1.GetProperties());
            foreach (var x in type_1.GetProperties())
            {
                write.WriteLine(x);
            }
        }
        public static void MethodInfo(string Class)
        {
            Type type_1 = GetType(Class);
            foreach (MethodInfo x in type_1.GetMethods())
            {
                Console.WriteLine("Метод " + type_1.Name);
            }

        }
        public static void Property_Field_info(string Class)
        {
            Type type_1 = GetType(Class);
            foreach (FieldInfo x in type_1.GetFields())
            {
                Console.WriteLine("Поле Name = " + x.Name);
               
            }            foreach (PropertyInfo x in type_1.GetProperties())
            {
                Console.WriteLine("Property Name = " + x.Name);

            }
        }
            public static void GetInterfaces(string Class, string param)
            {
            Type t = GetType(Class);
            Console.WriteLine($"Методы класса {t.Name} с параметром {param}");
            foreach (var x in t.GetMethods())
            {
                foreach (ParameterInfo y in x.GetParameters())
                {
                    if (y.ParameterType.ToString() == param)
                        Console.WriteLine(x);
                }
            }
            Console.WriteLine();
            }
        public static void CallMethodFromFile(string Class, string MethodName)
        {
            StreamReader reader = new StreamReader(@"D:\универ\3 сем\ООп\Лабы\№ 12\Laba12\Param.txt");
            List<string> param = new List<string>();
            while (!reader.EndOfStream)
            {
                param.Add(reader.ReadLine());
            }
            foreach (var x in GetType(Class).GetMethods())
            {
                if (x.Name == MethodName)
                {
                    x.Invoke(null, param.ToArray());
                }
            }
            reader.Close();
        }

    }
}
