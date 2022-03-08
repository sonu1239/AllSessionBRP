using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOPS__AllSession
{
    class S18__StringAndStrinBuilder
    {

        public void StringManupulation()
        {
            string names = "Abhilasha";
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                names = names + names;
                Console.WriteLine("Names Are: " + names);
            }

            timer.Stop();
            Console.Write("\nTime For String is : " + timer.ElapsedMilliseconds + "\n\n");
        }

        public void StringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder("Amit Kumar");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.Append("Deshmukh");
                Console.WriteLine("\tNames Are: " + stringBuilder);
            }
            timer.Stop();
            Console.Write("\nTime For StringBuilder is : " + timer.ElapsedMilliseconds);
        }

        public void StringBuilder_Methods()
        {
            StringBuilder stringBuilder = new StringBuilder("\n\nAmit Kumar Deshmukh");

            stringBuilder.Insert(4, "ee");
            stringBuilder.AppendLine("Patil");
            stringBuilder.Remove(6, 3);
            stringBuilder.AppendFormat("{0:X}", 25);
            Console.WriteLine("\tNames Are: " + stringBuilder);
        }
    }



}

    

