using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*         var name = "Scott Mosher";
                     var location = "Springville, UT";

                     Console.WriteLine("this" + "this");


                     // Get the current date & date of Christmas
                     DateTime currentDate = DateTime.Now;
                     DateTime christmas = new DateTime(2020, 12, 25);
                     TimeSpan daysTilChristmas = christmas.Subtract(currentDate);

                     Console.WriteLine($"My name is {name}, and I currently live in {location}.");
                     Console.WriteLine("Current Date: " + currentDate.ToString("d"));
                     Console.WriteLine($"Days til Christmas 2020: {daysTilChristmas.Days}");

                     // Glazer Calc stuff
                     Console.WriteLine("\n-----  Glazer Calc -----");
                     Console.Write("\nWidth: ");
                     double width = Convert.ToDouble(Console.ReadLine());

                     Console.Write("Height: ");
                     double height = Convert.ToDouble(Console.ReadLine());

                     GlazerCalc doubleGlaze = new GlazerCalc(width, height);

                     doubleGlaze.getArea();

                     Console.WriteLine("Press any key to close.");
                     Console.ReadKey();*/

            int x = 1;
            while (x++ < 5)
            {
                if (x % 2 == 0)
                    x += 2;
                Console.WriteLine("test");
            }
        }
    }

    class GlazerCalc
    {
        public double width;
        public double height;


        public GlazerCalc(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public void getArea()
        {
            double woodLength;
            double glassArea;

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width + height);

            Console.WriteLine($"The length of the wood is {woodLength} feet.");
            Console.WriteLine($"The area of the glass is {glassArea} square metres");
        }
    }


}


