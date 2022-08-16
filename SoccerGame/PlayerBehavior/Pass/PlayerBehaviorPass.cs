using SoccerGame.PlayerBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoccerGame
{
    public class PlayerBehaviorPass : IPassBehavior
    {
        double _passPercentage;
        Random _rnd = new Random();
        public bool Pass(List<double> skillKit)
        {
            for (int i = 0; i < skillKit.Count; i++)
            {
                double listData = skillKit[i];

                listData = _rnd.Next(50, 101);

                _passPercentage = listData * _rnd.NextDouble();
            }
            Console.WriteLine(_passPercentage);
            return _passPercentage > 20 ? true : false;
        }
    }
}
