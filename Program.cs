using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoccerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goalPercentage = true;
            int formNumber;
            int passControl = 12;
            Random random = new Random();
            List<Football> soccerTeam = new List<Football>();

            soccerTeam.Add(new Football("Keeper", 0));
            soccerTeam.Add(new Defense("Defans1", 1));
            soccerTeam.Add(new Defense("Defans2", 2));
            soccerTeam.Add(new Defense("Defans3", 3));
            soccerTeam.Add(new Defense("Defans4", 4));
            soccerTeam.Add(new Midfield("Midfield1", 5));
            soccerTeam.Add(new Midfield("Midfield2", 6));
            soccerTeam.Add(new Midfield("Midfield2", 7));
            soccerTeam.Add(new Midfield("Midfield4", 8));
            soccerTeam.Add(new Forward("Forward1", 9));
            soccerTeam.Add(new Forward("Forward2", 10));

            formNumber = random.Next(0, 11); ;
            for (int i = 0; i < 3; i++)
            {
                while (passControl == formNumber)
                {
                    formNumber = random.Next(0, 11);
                }
                passControl = formNumber;

                if (soccerTeam[formNumber].Pass().Equals(false))
                {
                    Console.WriteLine(formNumber + " Number player's pass fail!");
                    Console.WriteLine("Restart Game...");
                    goalPercentage = false;
                    break;
                }
                else
                {
                    Console.WriteLine(formNumber + " Number player's pass successful!");
                    Thread.Sleep(1500);
                }
            }
            if (goalPercentage.Equals(true))
            {
                if (soccerTeam[formNumber].GoalShot().Equals(true))
                {
                    Console.WriteLine(formNumber + " Number is player shot!!");
                    Thread.Sleep(2000);
                    Console.WriteLine("GOOOOOOOOOOAAALLL!");
                }
                else
                {
                    Console.WriteLine("The player missed!");
                    Console.WriteLine("Restart Game...");
                }
            }

            Console.ReadLine();



        }
    }
}
