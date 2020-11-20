using System;
using System.Collections.Generic;
using System.Linq;

namespace planYourHeistAgain
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Plan Your Heist!");
            //declared what name is
            string name = null;
            int difficultyLevel = 100;
            //creating an empty list
            List<TeamMember> teammates = new List<TeamMember>();
            //while loop to run through the team members. while name is entered continue with other questions
            while (name != "")
            {
                Console.WriteLine("Enter team members name");
                name = Console.ReadLine();
                // stops and exit if they don't enter a name
                if (name == "")
                {
                    break;
                }
                //skill level prompt and input
                Console.WriteLine("Enter skill level");
                int skillLevel = int.Parse(Console.ReadLine());
                //courage factor prompt and input
                Console.WriteLine("Enter courage factor");
                decimal courageFactor = int.Parse(Console.ReadLine());
                //creating the team members
                TeamMember newTeammate = new TeamMember()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    CourageFactor = courageFactor
                };
                //addding the team member
                teammates.Add(newTeammate);

            }
            //display the team members
            // foreach (TeamMember teammate in teammates)
            // {
            //     Console.WriteLine($"Name:{teammate.Name} Skill Level:{teammate.SkillLevel} CourageFactor:{teammate.CourageFactor}");
            // }
            //counting the number of teammates in a team with the .count method
            Console.WriteLine($"The number of teammates is {teammates.Count()}");
            int teamSkillLevel = teammates.Sum(teammate => teammate.SkillLevel);
            if (teamSkillLevel >= difficultyLevel)
            {
                Console.WriteLine("This heist will be successful!");
            }
            else
            {
                Console.WriteLine("This heist will fail");
            }
            Console.WriteLine(teamSkillLevel);

        }
    }
}
