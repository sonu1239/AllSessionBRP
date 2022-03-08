using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOPS__AllSession
{
    class S18_StringAndStringBuilder
    {
        public void StringManupulation()
        {
            string names = "Abhilash";
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                names = names + names;
                Console.WriteLine(names);
            }
            timer.Stop();
            Console.WriteLine("\nTime for string ");

        }
        public void stringBuilder()
        {

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Amit");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
              
            }
            timer.Stop();
            Console.WriteLine("\nTime for string ");


        }

    }
}
