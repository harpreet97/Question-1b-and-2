using System;

namespace Question_2
{
    class Car
    {
        private string Colour { get; set; }
        private string Make { get; set; }
        private string Gearbox { get; set; }

        public Car(string colour, string make, string gearbox)
        {
            Colour = colour;
            Make = make;
            Gearbox = gearbox;
        }
        public string DescribeCar()
        {
            return string.Format("This car is a {0} {1} with a {2} transmission.", Colour, Make, Gearbox);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter new car details below");
            Console.WriteLine("***************************************");
            Console.WriteLine("Please enter the colour of the your car?");
            string colour = Console.ReadLine();
            Console.WriteLine("Please enter the make of the your car?");
            string make = Console.ReadLine();
            Console.WriteLine("Please enter the gearbox type of the your car?");
            string gearbox = Console.ReadLine();
            Car obj = new Car(colour, make, gearbox);
            Console.WriteLine(obj.DescribeCar());
        }
    }
}
