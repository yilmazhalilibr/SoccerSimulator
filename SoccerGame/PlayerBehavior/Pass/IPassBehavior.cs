using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.PlayerBehavior
{
    public interface IPassBehavior
    {
        
        bool Pass(List<double> skillKit);
        
    }
}
