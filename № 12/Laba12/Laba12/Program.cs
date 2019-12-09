using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Laba12
{
    class Program
    {
        static void Main(string[] args)
        {
            User q_1 = new User("Nikita", 18 );
            Reflector.WriteTofile("Animals");
            Reflector.WriteTofile("User");

            Reflector.MethodInfo("Animals");
            Reflector.MethodInfo("User");

            Reflector.Property_Field_info("Animals");
            Reflector.Property_Field_info("User");

            Reflector.GetInterfaces("Animals", "System.String");
            
            Reflector.CallMethodFromFile("Animals","ToString");
            Reflector.CallMethodFromFile("User","Display");
        }
    }
}
