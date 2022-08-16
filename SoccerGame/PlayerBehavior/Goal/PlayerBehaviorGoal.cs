using SoccerGame.PlayerBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoccerGame
{
    public class PlayerBehaviorGoal : IGoalBehavior
    {
      

        private double _passPercentage;
        public bool Goal(List<double> skillKit)
        {
            var randomValue = Player.random.NextDouble();
            for (int i = 0; i < skillKit.Count; i++)
            {
                
                double listData = skillKit[i];
                listData = Player.random.Next(50, 101);
                _passPercentage = listData * randomValue;

            }
            Console.WriteLine(_passPercentage);
            return _passPercentage > 70 ? true : false;
        }
    }
}
