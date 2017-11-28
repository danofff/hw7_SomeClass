using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_SomeClass
{
    class SimpleClass
    {
        private static Random rnd = new Random();

        public int SomeVar { get; set; }
        public string SomeName { get; set; }

        public SimpleClass()
        {
            SomeVar = rnd.Next(0, 10);
            SomeName = "Noname";
        }
        public SimpleClass(int someVar):this(someVar,"Noname")
        {
            //SomeVar = someVar;//избыточно!!!! если ты его сейчас передашв следующий конструктор!!!!
        }
        public SimpleClass(int someVar,string someName)
        {
            SomeVar = someVar;
            SomeName = someName;
        }



        /*
         * Почему нет проверки на NULL, вдруг передадут пустыеклассы! Что тогда, ошибка!!!!
         */
        public static bool operator==(SimpleClass obj1,SimpleClass obj2)
        {
            if (obj1 != null && obj2 != null)
                return obj1.SomeVar == obj2.SomeVar;
            else
                return false;
        }
        public static bool operator !=(SimpleClass obj1, SimpleClass obj2)
        {
            if (obj1 != null && obj2 != null)
                return obj1.SomeVar != obj2.SomeVar;
            else
                return false;
        }

        public  bool  Equals(SimpleClass obj)
        {
            return this.SomeVar == obj.SomeVar;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name:{SomeName} Value: {this.SomeVar}");
        }
    }
}
