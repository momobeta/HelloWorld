
// C# program to print Hello World!
using System;
  
// namespace declaration
namespace Application {
      
    // Class declaration
    class Clock {
          
        // Main Method
        public static void Mainn(string[] args) {
              
            // statement
            // printing Hello World!
            bool flag = false;
            double hours = 0;
            double minutes = 0;

            while (!flag)
            {
                Console.WriteLine("Please input date in the format HH:MM");
                String clock = (String) Console.ReadLine();
                
                String[] separator = {":"};
                String[] split = clock.Split(separator, 5, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    hours = (double.Parse(split[0])) % 12;
                    minutes = (double.Parse(split[1])) % 60;
                    flag = true;
                }
                catch (System.Exception)
                {                    
                    Console.WriteLine("You did something wrong, please try again");
                }
            }
            
            double hoursDegrees = hours * 360.0/12;
            double minutesDegrees = minutes * 360.0/60;

            double difference = Math.Abs(hoursDegrees - minutesDegrees);

            if (difference > 180)
                difference = 360 - difference;

            Console.WriteLine("Difference in degrees is: " + difference);
        }
    }

}