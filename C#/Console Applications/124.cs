using System;
namespace A
{
    class Test
    {
        public void greetone()
        {
            System.Console.WriteLine("Good Morning");
        }
    }
    namespace B
    {
        class Test
        {
            public void greettwo()
            {
                System.Console.WriteLine("Good Afternoon");
            }
        }
        namespace C
        {
            class Test
            {
                public void greetthree()
                {
                    System.Console.WriteLine("Good Evening");
                }
                public static void Main()
                {
                    A.Test obj1 = new A.Test();
                    obj1.greetone();
                    B.Test obj2 = new B.Test();
                    obj2.greettwo();
                    C.Test oj3 = new C.Test();
                    oj3.greetthree();

                }
            }
        }
    }
}