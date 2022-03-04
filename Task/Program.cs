using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aslan

            //double number = 8;

            // if (number % 2 == 0 || number == 1)
            // {
            //     while (number > 1)
            //     {
            //         //number = number / 2;
            //         number /= 2;
            //     }
            //     if (number == 1)
            //     {
            //         Console.WriteLine("2 quvetidir");
            //     }
            //     else
            //     {
            //         Console.WriteLine("2QUVVETI DEYIL");
            //     }


            // }
            // else
            // {
            //     Console.WriteLine("2 ye bolunmur");
            // }
            #endregion
            #region Sasa
            int number = 1;

                while (number>2)
            {
                if(number%2==0)
                {
                    number /= 2;
                }
                else
                {
                    break;
                }

            }

            if (number == 2 || number==1)
            {
                Console.WriteLine("True !");
            }
            else { Console.WriteLine("False"); }
            #endregion
        }
    }
}
