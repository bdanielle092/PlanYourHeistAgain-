﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace planYourHeistAgain
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("--------------------");
            //declared what name is
            string name = null;
            //difficulty level prompt and input
            Console.WriteLine("Entry difficulty level");
            int difficultyLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------");


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
                Console.WriteLine("Enter courage factor (0.0 - 0.2)");
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
            Console.WriteLine("Enter how many times does your team wants to rob the bank:");
            int heistAttempts = int.Parse(Console.ReadLine());
            //variable to hold success and failures of heist attempts
            int numOfSuccessfulAttempts = 0;
            int numOfFailAttempts = 0;

            //use a for loop to loop through the number of heistAttempt
            for (int num = 0; num < heistAttempts; num++)
            {

                //using random.Next() to get a random number between -10 and 10 
                int luckyValue = new Random().Next(-10, 10);
                //adding the luckyValue and difficultyLevel together
                int luckAndDifficulty = luckyValue + difficultyLevel;

                //display the team members
                // foreach (TeamMember teammate in teammates)
                // {
                //     Console.WriteLine($"Name:{teammate.Name} Skill Level:{teammate.SkillLevel} CourageFactor:{teammate.CourageFactor}");
                // }
                //counting the number of teammates in a team with the .count method
                Console.WriteLine($"The number of teammates is {teammates.Count()}");
                int teamSkillLevel = teammates.Sum(teammate => teammate.SkillLevel);
                Console.WriteLine($"Teams Skill Level:{teamSkillLevel} and Difficulty Level:{luckAndDifficulty}");
                //if team skill level is higher or equal to luckAndDifficulty then the heist will be successful otherwise it will fail
                if (teamSkillLevel >= luckAndDifficulty)
                {
                    Console.WriteLine("This heist will be successful!");
                    Console.WriteLine();
                    //everytime your successfull it add to the variable numOfSuccessfulAttempt
                    numOfSuccessfulAttempts++;
                }
                else
                {
                    Console.WriteLine("This heist will fail");
                    Console.WriteLine();
                    //everytime your successfull it add to the variable numOfFailAttempt
                    numOfFailAttempts++;
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Your team was successful {numOfSuccessfulAttempts} time(s) and your team failed {numOfFailAttempts} time(s)");




        }
    }
}
