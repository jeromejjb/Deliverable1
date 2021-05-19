using System;

namespace Deliverable1
{
    class Program
    {


        static void Main(string[] args) {


            string measurementType;
            int inch;
            int fidgetspinners;
            int foot;
            int meme;
            string userAnswer = "yes";

            while (userAnswer == "yes")
            {
                // asking for a users measurement input
                Console.Write("Please enter a measurement type ");
                measurementType = Console.ReadLine();

                // asking user for an amount of measurement
                Console.Write("Enter an amount ");

                if (measurementType == "inch")
                {

                    fidgetspinners = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("That converts to {0} fidget spinners", fidgetspinners * 3.5);
                }
               else if (measurementType == "fidget spinners")
                {
                    inch = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("That converts to {0} inches", inch * 1);
                }
                else if (measurementType == "foot")
                {
                    meme = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("That converts to {0} memes", meme *  5);
                }
                else if (measurementType == "meme")
                {
                    foot = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("That converts to {0} feet", foot * 5);
                }
                Console.Write("would you like to do another calculation? ");
                userAnswer = Console.ReadLine();
             

            }
        }
    }
}




