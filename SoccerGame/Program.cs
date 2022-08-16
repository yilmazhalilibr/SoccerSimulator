using SoccerGame.Players;
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
            List<Player> _soccer = new List<Player>();
            _soccer.Add(new PlayerDefense("Defense", 0));
            _soccer.Add(new PlayerDefense("Defense1", 1));
            _soccer.Add(new PlayerDefense("Defense2", 2));
            _soccer.Add(new PlayerMidfield("Midfield1", 3));
            _soccer.Add(new PlayerMidfield("Midfield2", 4));
            _soccer.Add(new PlayerForward("Forward1", 5));
            _soccer.Add(new PlayerForward("Forward2", 6));



            bool passSuccses = false;

            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                int rdn = rand.Next(0, 7);
                var player = _soccer[rdn];
                if (player.PerformPass())
                {
                    Console.WriteLine(rdn + " No Player : Succses Pass!");
                    if (i == 2)
                    {
                        passSuccses = true;

                    }
                    continue;
                }
                else
                {
                    Console.WriteLine("Pass Failed, Game Over!");
                    break;
                }


            }

            if (passSuccses == true)
            {
                Console.WriteLine("GOAL POSITION!!!!!!");
                int random = rand.Next(0, 7);
                if (_soccer[random].PerformGoal())
                {
                    Console.WriteLine("GOOOOAAAALL!!! \n WINNER!!!");
                }
                else
                {
                    Console.WriteLine("GAME OVER ! \nGOAL FAILED !");
                }

            }






            Console.ReadLine();



        }
    }
}
