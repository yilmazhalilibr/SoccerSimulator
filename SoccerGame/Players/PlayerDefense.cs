using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Players
{
    class PlayerDefense : Player
    {
        private double _position;
        private double _jump;

        public PlayerDefense(string name, int formNumber) : base(name, formNumber)
        {
            SkillKit.Add(_position);
            SkillKit.Add(_jump);
            base.SetSkillKit(50);
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
