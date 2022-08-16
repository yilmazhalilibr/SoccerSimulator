using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame.Players
{
    class PlayerMidfield : Player
    {
        private double _longshot;
        private double _productivity;
        private double _ballControl;

        public PlayerMidfield(string name, int formNumber) : base(name, formNumber)
        {
            SkillKit.Add(_longshot);
            SkillKit.Add(_productivity);
            SkillKit.Add(_ballControl);
            base.SetSkillKit(70);
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
