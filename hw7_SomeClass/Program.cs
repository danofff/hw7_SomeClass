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
            SimpleClass c1 = new SimpleClass();
            SimpleClass c2 = new SimpleClass();
            c1.PrintInfo();
            c2.PrintInfo();

            Console.WriteLine("overload ==");
            Console.WriteLine(c1 == c2);

            Console.WriteLine("overload !=");
            Console.WriteLine(c1 != c2);

            Console.WriteLine("overload Equals");
            Console.WriteLine(c1.Equals(c2));
        }
    }
}
