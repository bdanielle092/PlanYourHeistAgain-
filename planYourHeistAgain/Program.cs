using System;
using System.Collections.Generic;

namespace planYourHeistAgain
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Plan Your Heist!");
            //declared what name is
            string name = null;
            //creating an empty list
            List<TeamMember> teammates = new List<TeamMember>();
            //while loop to run through the team members
            while (name != "")
            {
                Console.WriteLine("Enter team members name");
                name = Console.ReadLine();
                // stops if they don't enter a name
                if (name == "")
                {
                    break;
                }
                Console.WriteLine("Enter skill level");
                int skillLevel = int.Parse(Console.ReadLine());
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
            foreach (TeamMember teammate in teammates)
            {
                Console.WriteLine(teammate);

            }


        }
    }
}
