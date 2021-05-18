using System;

namespace Deliverable1
{
    class Program
    {


        static void Main(string[] args) {


            string measurementType;
            int milhip;
            int imperial;
            string userAnswer = "yes";

            while (userAnswer == "yes")
            {  
                // asking for a users measurement input
                Console.Write("Please enter a measurement type ");
                measurementType = Console.ReadLine();

                // asking user for an amount of measurement
                Console.Write("Enter an amount ");
               
                if (measurementType == "milhip")
                {
                    // convert measurement if in milhip to Figet spinners and Memes
                    milhip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} Figet Spinners", milhip * 3.5);
                    Console.WriteLine("{0} Memes", milhip * 5);   
                }
                else
                {
                    // convert measurement if in imperial to inches and feet
                    imperial = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} inches", imperial * 1);
                    Console.WriteLine("{0} feet", imperial * 1);
                }
                Console.Write("would you like to do another calculation? ");
                userAnswer = Console.ReadLine();  
            }
        }
    }
}




