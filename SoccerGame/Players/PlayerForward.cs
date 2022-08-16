using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Players
{
    class PlayerForward : Player
    {
        private double _terminate;
        private double _iceBlood;

        public PlayerForward(string name, int formNumber) : base(name, formNumber)
        {

            SkillKit.Add(_terminate);
            SkillKit.Add(_iceBlood);
            base.SetSkillKit(60);
            GoalBehavior = new PlayerBehaviorGoal();
            PassBehavior = new PlayerBehaviorPass();

        }
        public override bool PerformPass()
        {
            return PassBehavior.Pass(SkillKit) ? true : false;

        }
        public override bool PerformGoal()
        {
           
            return GoalBehavior.Goal(SkillKit) ? true : false;
        }

    }

}
