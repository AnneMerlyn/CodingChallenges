using System;

namespace CodingChallenges { 
   

    class Program
    {
        static void Main(string[] args)
        {
            //Coding Challenge : Work out the number of Days
            Console.WriteLine("Coding Challenge : Work out the number of Days");
            DateTime fromDate = DateTime.Now;
            DateTime toDate = new DateTime(2023, 12, 19);

            int daysLeft = DateFunctions.DaysLeft(fromDate, toDate);
            Console.WriteLine($"Days left: {daysLeft}");

            //Coding Challenge: string removal
            Console.WriteLine($"{Environment.NewLine}Coding Challenge: string removal");
            string value = "Hello";
            string result = RemoveLastCharacterFunctions.RemoveLastCharacter(value);
            Console.WriteLine("Current String: {0}", value);
            Console.WriteLine("Result of the string from Removal: {0}", result);

            //Convert MHP to KPH
            Console.WriteLine($"{Environment.NewLine}Convert MHP to KPH");
            decimal speed = 100;
            decimal convertedSpeed = SpeedHelper.ConvertSpeed(speed, SpeedTypeEnum.KPH);

            Console.WriteLine("Speed in MPH: {0}", speed);
            Console.WriteLine("Speed in KPH: {0}", convertedSpeed);
        } 
    }
}