using System;

namespace Deliverable1
{
    class Program
    {


        static int Main(string[] args)
        {
            string measurementType;
            int milhip;
            int imperial;



            Console.Write("Please enter a measurement type ");
            measurementType = Console.ReadLine();
            // asking for a users measurement input

            Console.Write("Enter an amount ");
            // asking user for an amount of measurement
            
            
             milhip = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Figet Spinners = {0}", milhip * 3.5);
             Console.WriteLine("Memes = {0}", milhip * 5);
            // convert measurement if in milhip to Figet spinners and Memes
             
            imperial = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("inches = {0}", imperial * 1);
            Console.WriteLine("feet = {0}", imperial * 1);
            // convert measurement if in imperial to inches and feet
         
         
         
        }
    }
}




