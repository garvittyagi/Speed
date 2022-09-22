using System.Diagnostics.CodeAnalysis;

namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance in Kilometers");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time in hours");
            double time = Convert.ToDouble(Console.ReadLine());
            double speedInKmph = distance / time;
            double speedInMph = speedInKmph / 1.609;
            Console.WriteLine("The speed in Kilometer per hour is : " + speedInKmph);
            Console.WriteLine("The speed in Miles per hour is : " + speedInMph);
            
            
        }
    }
}