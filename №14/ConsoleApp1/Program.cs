using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Predator tiger = new Predator("Africa", "Tiger", 15);
            Predator Lion = new Predator("Africa", "Lion", 10);
            Predator Wolf = new Predator("Europe", "Wolf", 2);
            Animals[] animals = new Animals[] { tiger, Lion, Wolf };
            foreach (object a in animals)
            {
                //Console.WriteLine(a.ToString);
            }
            BinarySerialize(tiger);
            BinaryDeserialize();
            JsonSerialize(Lion);
            JsonDeserialize();
            SOAPSerialize(Wolf);
            SOAPDeserialize();
            XMLSerialize(tiger);
            XMLDeserialize();
            //Array_JsonSerialize(animals);
            //Array_JsonDeserialize();
            Array_XMLSerialize(animals);
            //Array_XMLDeserialize();
            XPath();
            XmlLinq();
        }

        static void BinarySerialize(object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter(); //создаем объект 
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("animals.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
                Console.WriteLine("Объект сериализован binary");

            }

        }
        static void BinaryDeserialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("animals.dat", FileMode.OpenOrCreate))
            {
                Predator newpredator = (Predator)formatter.Deserialize(fs);
                Console.WriteLine($"{newpredator.predator}\n Название :  {newpredator.name } Место обитания : {newpredator.Habitat} Возраст: {newpredator.age} ");
                Console.WriteLine("Объект десериализован binary");
            }
        }
        static void JsonSerialize(object obj)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Predator));
            using (FileStream fs = new FileStream("predator.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(fs, obj);
                Console.WriteLine("Сериализация JSON завершена");
            }
        }
        static void JsonDeserialize()
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Predator));
            using (FileStream fs = new FileStream("predator.json", FileMode.OpenOrCreate))
            {
                Predator predator = (Predator)json.ReadObject(fs);
                
                predator.Show();
                Console.WriteLine("Объект десериализован Json");
            }
        }
        static void SOAPSerialize(object obj)
        {
            // создаем объект SoapFormatter
            SoapFormatter formmater = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("predator.soap", FileMode.OpenOrCreate))
            {
                formmater.Serialize(fs, obj);
                Console.WriteLine("Объект сериализован SOAP");
   
            }
        }
        static void SOAPDeserialize()
        {
            SoapFormatter formatter = new SoapFormatter();
            using (FileStream fs = new FileStream("predator.soap", FileMode.OpenOrCreate))
            {
                Predator predators = (Predator)formatter.Deserialize(fs);
                Console.WriteLine("Десериализован SOAP");
                predators.Show();
             }

        }
        static void XMLSerialize(object obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Predator));
            using (FileStream fs = new FileStream("predator.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
                Console.WriteLine("объект сериализован XML");
            }
        }

        static void XMLDeserialize()
        {
            XmlSerializer deserialize = new XmlSerializer(typeof(Predator));
            using (FileStream fs = new FileStream("predator.xml", FileMode.OpenOrCreate))
            {
                Predator predator = (Predator)deserialize.Deserialize(fs);
                predator.Show();
                Console.WriteLine("XML десериализован");
            }
         }

        static void Array_JsonSerialize(object obj)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Animals[]));
            using (FileStream fs = new FileStream("predator_array.json", FileMode.OpenOrCreate))
            {
                json.WriteObject(fs, obj);
                Console.WriteLine("Сериализация массива JSON завершена");
            }
        }
        static void Array_JsonDeserialize()
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(Animals[]));
            using (FileStream fs = new FileStream("predator_array.json", FileMode.OpenOrCreate))
            {
                Animals[] predator = (Animals[])json.ReadObject(fs);

                //predator.Show();
                Console.WriteLine("Массив  объектов десериализован Json");
            }
        }

        static void Array_XMLSerialize( object obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Animals[]));
            using (FileStream fs = new FileStream("predator_array.xml", FileMode.OpenOrCreate))
            {
              formatter.Serialize(fs, obj);
                Console.WriteLine("массив объекто сериализован XML");
            }
        }
        static void Array_XMLDeserialize()
        {
            XmlSerializer deserialize = new XmlSerializer(typeof(Animals[]));
            using (FileStream fs = new FileStream("predator_array.xml", FileMode.OpenOrCreate))
            {
                Animals[] predators = (Animals[])deserialize.Deserialize(fs);
                foreach (Animals item in predators)
                {
                    // predators.Show();
                }
                Console.WriteLine("XML десериализован");
            }
        }    //XPath представляет язык запросов в XML
        static void XPath()
        {
            Console.WriteLine("XML:");
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Xpath.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            // выбор 
            XmlNode childnode = xRoot.SelectSingleNode("SPECIALIZATION[University='БГТУ']");
            if (childnode != null)
                Console.WriteLine(childnode.OuterXml);
            Console.WriteLine();
            XmlNode childnode1 = xRoot.SelectSingleNode("SPECIALIZATION[TOWN='Брест']");
            if (childnode1 != null)
                Console.WriteLine(childnode.OuterXml);

        }
            static void XmlLinq()
            {
                XDocument xDoc = new XDocument(new XElement("OOP", new XElement("LABS", new XElement("Osoprilko_Nikita"), new XElement("My_github_Nikitand"), new XElement("Its_all"))));
                xDoc.Save("oop.xml");
            }
       
        
    }
  

}
