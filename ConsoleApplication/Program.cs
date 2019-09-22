using System;

namespace ConsoleApplication
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //where i am from
            var name = "Cameron";
            var location = "Texas";
            
            Console.WriteLine("My name is "+ name +", I am from "+ location);

            //current date without time 

            DateTime dateTime = DateTime.UtcNow.Date;
            Console.WriteLine("Todays Date:");
            Console.WriteLine(dateTime.ToString("d"));

            //days until christmas

            DateTime christmas = new DateTime(2019, 12, 25);

            DateTime today = DateTime.Today;
            DateTime next = christmas.AddYears(today.Year - christmas.Year);

            if (next < today)
                next = next.AddYears(1);

            int numDays = (next - today).Days;

            Console.WriteLine("Days Until Christmas:");
            Console.WriteLine(numDays + " Days until Christmas" );

            //2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Enter in width.");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Enter in Height.");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is {woodLength} feet");
            Console.WriteLine("The area of the glass is {glassArea} square metres");

           
            Console.ReadKey();
        }
    }
}
