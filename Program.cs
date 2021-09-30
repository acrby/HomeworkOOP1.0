using System;

namespace HomeworkOOP1._0
{

    class MyClass
    {
       public int fieldOfClass;

        public void Method ()
        {
            Console.WriteLine(fieldOfClass);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.fieldOfClass = 1;
            a.Method();

            MyClass b = new MyClass();
            b.fieldOfClass = 2;
            b.Method();

            Console.ReadKey();
        }
    }
}
