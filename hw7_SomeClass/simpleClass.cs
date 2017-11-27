using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_SomeClass
{
    class simpleClass
    {
        private static Random rnd = new Random();
        private int someVar;

        public int SomeVar
        {
            get { return someVar; }
            set { someVar = value; }
        }
        private string someName;

        public string SomeName
        {
            get { return someName; }
            set { someName = value; }
        }
        public simpleClass()
        {
            this.SomeVar = rnd.Next(0, 10);
            this.SomeName = "Noname";
        }
        public simpleClass(int someVar):this(someVar,"Noname")
        {
            this.SomeVar = someVar;
        }
        public simpleClass(int someVar,string someName)
        {
            this.SomeVar = someVar;
            this.SomeName = someName;
        }
        public static bool operator==(simpleClass obj1,simpleClass obj2)
        {
            return obj1.SomeVar == obj2.SomeVar;
        }
        public static bool operator !=(simpleClass obj1, simpleClass obj2)
        {
            return obj1.SomeVar != obj2.SomeVar;
        }
        public  bool  Equals(simpleClass obj)
        {
            return this.SomeVar == obj.SomeVar;
        }
        public void printInfo()
        {
            Console.WriteLine($"Name:{this.someName} Value: {this.SomeVar}");
        }
    }
}
