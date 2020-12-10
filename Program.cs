using System;

namespace kelly_james_app1
{
    class MonthGrind
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("This Program Created will tell you how many days that are each Month...Press any key to continue: ");
            Console.ReadKey();
            Console.WriteLine("Presented by James Kelly \n");
            Console.WriteLine("Day/Month Calculator:\n ");
            Console.WriteLine("Please enter the month number: ");
            int monthNum = Convert.ToInt32(Console.ReadLine());

            Month month = new Month(monthNum);

            Console.WriteLine(month);
            Console.ReadKey();  //Press Enter 
            Console.WriteLine("Thanks! ");

        }
    }
}
