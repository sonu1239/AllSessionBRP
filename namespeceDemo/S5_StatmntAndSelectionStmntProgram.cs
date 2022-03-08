using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSession
{
    class S5_StatmntAndSelectionStmntProgram
    {

        public void MarkChecker()
        {
            //IF...IF Then IF...else if
            Console.Write("Enter Percentage value \t");
            int percentage = int.Parse(Console.ReadLine());
            if (percentage >= 80)
                Console.WriteLine("Congrats!  You Pass the Exam");
            // Console.WriteLine("Wish You best Luck");        // Error 
            else if (percentage >= 60)
                Console.WriteLine("Good! You Are Eligible For Commerce");
            else if (percentage >= 50)
                Console.WriteLine("All The Best");
            else if (percentage < 35)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Sorry! \tTry Next Time");
        }

        //Nested If OR If...If OR else...IF
        public void NestedIf()
        {
            int no1 = 52;
            if (no1 > 50)
            {
                if (no1 < 40)
                    Console.Write("Less");
                else
                    Console.Write("Big");
            }
            else
            {
                if (no1 == 52)
                    Console.WriteLine("Value is Eqaul");
                else
                    Console.WriteLine("Value is NotEqual");
            }
        }

        //switchCase
        public void SwitchCase()
        {
            Console.WriteLine("Enter Week Number \t");
            int weekNo = int.Parse(Console.ReadLine());
            switch (weekNo)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednsday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter Valid Number");
                    break;
            }
        }

        public void SwitchGroup()
        {
            Console.Write("Enter Character\t ");
            char alpha = Convert.ToChar(Console.ReadLine());
            switch (alpha)
            {
                case 'a':
                case 'e':
                case 'o':
                case 'u':
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'A':
                    Console.Write("**********You Are in Capital Alphabate :-- \n Enter Capital Character:  ******* \t");
                    char cap = Convert.ToChar(Console.ReadLine());
                    switch (cap) //Nested Case
                    {
                        case 'A':
                        case 'E':
                        case 'O':
                        case 'U':
                        case 'I':
                            Console.Write($"{cap} is Vowel");
                            break;
                        default:
                            Console.WriteLine($"{cap} Not Vowel");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Not Vowel");
                    break;
            }

        }
    }   
}

