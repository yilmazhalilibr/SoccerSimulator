using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame
{
    public interface IPlayerBehavior
    {
        bool Pass();
        bool GoalShot();
    }
}
