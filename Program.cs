namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valueMax, valueMin, valueTarget;
            Console.WriteLine("Please input a low number");
            valueMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input a second higher number");
            valueMax = int.Parse(Console.ReadLine());
            Console.WriteLine($"please input a number that falls in between {valueMin} and {valueMax}");
            valueTarget = int.Parse(Console.ReadLine());
            while (valueTarget < valueMin || valueTarget > valueMax)
            {
                Console.WriteLine($"The number you have entered does not fall in between {valueMin} and {valueMax}, Please try again: ");
                valueTarget = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Good job");
            System.Environment.Exit(0);


        }
    }
}