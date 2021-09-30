using System;
//using Robot;


namespace Robot{
    class MyClass
    {
        public int fieldOfClass;

        public void Method()
        {
            Console.WriteLine(fieldOfClass);
        }
    }
}

namespace HomeworkOOP1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot.MyClass a = new Robot.MyClass();
            a.fieldOfClass = 1;
            a.Method();

            Robot.MyClass b = new Robot.MyClass();
            b.fieldOfClass = 2;
            b.Method();

            Console.ReadKey();
        }
    }
}
