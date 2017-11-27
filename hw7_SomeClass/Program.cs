using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_SomeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            simpleClass c1 = new simpleClass();
            simpleClass c2 = new simpleClass();
            c1.printInfo();
            c2.printInfo();
            Console.WriteLine("overload ==");
            Console.WriteLine(c1 == c2);
            Console.WriteLine("overload !=");
            Console.WriteLine(c1 != c2);
            Console.WriteLine("overload Equals");
            Console.WriteLine(c1.Equals(c2));
        }
    }
}
