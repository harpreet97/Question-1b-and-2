using System;

namespace Question_2
{
    class Car
    {
        private string colour { get; set; }
        private string make { get; set; }
        private string gearbox { get; set; }

        public Car(string col, string mk, string gbox)
        {
            colour = col;
            make = mk;
            gearbox = gbox;
        }
        public string DescribeCar()
        {
            return string.Format("This car is a {0} {1} with a {2} transmission.", colour, make, gearbox);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter new car details below");
            Console.WriteLine("***************************************");
            Console.Write("Colour: ");
            string col = Console.ReadLine();
            Console.WriteLine("");

            Console.Write("Make: ");
            string mk = Console.ReadLine();;
            Console.WriteLine("");

            Console.Write("Gearbox type: ");
            string gbox = Console.ReadLine();
            Console.WriteLine("");
            Car obj = new Car(col, mk, gbox);
            Console.WriteLine(obj.DescribeCar());
        }
    }
}
