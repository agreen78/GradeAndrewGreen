using System;

namespace GradeAndrewGreen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What total score out of 100 they expect to get in ISM 4300?");

            int Grade;
            Grade = int.Parse(Console.ReadLine());

            if (Grade >= 98)
            {
                Console.WriteLine("A+");
            }
            else if (Grade >= 92)

            {
                Console.WriteLine("A");
            }
            else if (Grade >= 90)

            {
                Console.WriteLine("A-");
            }
            else if (Grade >= 88)

            {
                Console.WriteLine("B+");
            }
            else if (Grade >= 82)

            {
                Console.WriteLine("B");
            }
            else if (Grade >= 80)

            {
                Console.WriteLine("B-");
            }
            else if (Grade >= 78)

            {
                Console.WriteLine("C+");
            }
            else if (Grade >= 72)

            {
                Console.WriteLine("C");
            }
            else if (Grade >= 70)

            {
                Console.WriteLine("C-");
            }
            else if (Grade >= 68)

            {
                Console.WriteLine("D+");
            }
            else if (Grade >= 62)

            {
                Console.WriteLine("D");
            }
            else if (Grade >= 60)

            {
                Console.WriteLine("D-");
            }
            else

            {
                Console.WriteLine("F"); 
            }
        }
    }
}
