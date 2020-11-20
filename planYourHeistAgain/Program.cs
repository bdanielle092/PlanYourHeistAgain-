using System;

namespace planYourHeistAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Enter team members name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter skill level");
            int skillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter courage factor");
            decimal courageFactor = int.Parse(Console.ReadLine());
            Console.WriteLine($"Team member info: Name: {name}, Skill Level: {skillLevel}, Courage Factor: {courageFactor}");

        }
    }
}
