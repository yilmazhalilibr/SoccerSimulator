using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.PlayerBehavior
{
    public interface IGoalBehavior
    {
        bool Goal(List<double> skillKit);
    }
}
