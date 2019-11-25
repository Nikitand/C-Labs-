using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10
{
    static class StaticClass
    {
        public static void method(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection changed!");
        }
    }
}
