using System;

namespace AllSesion
{ 
    class session1
    {
        int a = 10;
        int b = 20;
        public void Addition()
        {
            int d = a + b;
            Console.WriteLine("addition is: {0}",d);
        }
    }

    namespace AllSession1
    {
        class session1
        {
            int a = 10;
            int b = 20;
            public void multiplication()
            { 
                int c = a * b;
                Console.WriteLine("multiplication is:{0}", c);
            }
        }
    }
}
