using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba11
{
    public partial class Airline
    {
        public uint makeHash(string des, int num, string t, weekDays day)
        {
            int intRes = des.Length + num * 9 - t.Length;
            if (day > weekDays.thir)
                intRes *= 54;
            uint res = (uint)intRes;
            return res;
        }



        public override bool Equals(object obj)
        {
            var Air = obj as Airline;

            if (Air == null)
            {
                return false;
            }

            return Air.NUMBER == NUMBER && Air.type == TYPE;
        }

        public override string ToString()
        {
            return "AIRLINE: " + "Тип"+ TYPE + "\t" +  "№ "+NUMBER + "\t" +"г." +  DESTINATION +"\t" + time +  "часа(ов)";
        }

    }
    partial class Airline
    {
        public string destination = "";
        public int number = 0;
        public string type = "";
        public int time = 0;
        public enum weekDays
        {
            sun = 1, mon, thue, wen, thir, fri, sat
        }
        private weekDays wd = weekDays.mon;
        private readonly uint FlightID;
        private static int size = 0;
        public static void sizeinfo()
        {
            Console.WriteLine("Size:" + size);
        }

        public string DESTINATION
        {
            get { return this.destination; }
            set { this.destination = value; }

        }
        public int NUMBER
        {
            get { return this.number; }
            set { this.number = value; }

        }
        public string TYPE
        {
            get { return this.type; }
            set { this.type = value; }

        }
        public weekDays DAY
        {
            get { return this.wd; }
            set { this.wd = value; }

        }
        public uint ID
        {
            get { return this.FlightID; }

        }
        public Airline()
        {
            this.destination = "no";
            this.number = 0;
            this.type = "no";
            this.time = 0000;
            this.wd = weekDays.sun;
            this.FlightID = makeHash(destination, number, type, wd);
            size++;
            Console.WriteLine("Конструктор без параметров!");

        }

        public Airline(string des, int n, string ty, int t, weekDays day)
        {
            this.destination = des;
            this.number = n;
            this.type = ty;
            this.time = t;
            this.wd = day;
            this.FlightID = makeHash(destination, number, type, wd);
            size++;
            Console.WriteLine("Конструктор с параметрами!");
        }

        static Airline()
        {
            Console.WriteLine("Статический конструктор!");
        }
        public Airline(string des, int n, string ty)
        {
            this.destination = des;
            this.number = n;
            this.type = ty;
            this.FlightID = makeHash(destination, number, type, wd);
            size++;
            Console.WriteLine("Просто конструктор!");
        }
        public Airline(string des, int n, string ty, int t)
        {
            this.destination = des;
            this.number = n;
            this.type = ty;
            this.time = t;
            
        }
        }
}
