using SoccerGame.PlayerBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame
{
    public abstract class Player
    {
        public IGoalBehavior GoalBehavior;
        public IPassBehavior PassBehavior;


        public List<double> SkillKit;
        public static Random random = new Random();

        protected string _name;
        protected int _formNumber;
        protected double _speed;
        protected double _durability;
        protected double _pass;
        protected double _shot;
        protected double _ability;
        protected double _stability;
        protected double _inherent;
        protected double _luck;
        protected double _specialAbility;
        protected double _head;
        protected double _firstTouch;

        public Player(string name, int formNumber)
        {
            SkillKit = new List<double>();
            _name = name;
            _formNumber = formNumber;

            GoalBehavior = new PlayerBehaviorGoal();
            PassBehavior = new PlayerBehaviorPass();
        }
        public virtual void SetSkillKit(int randomInt)
        {
            SkillKit = new List<double>();

            SkillKit.Add(_speed);
            SkillKit.Add(_durability);
            SkillKit.Add(_pass);
            SkillKit.Add(_shot);
            SkillKit.Add(_ability);
            SkillKit.Add(_stability);
            SkillKit.Add(_inherent);
            SkillKit.Add(_luck);
            SkillKit.Add(_specialAbility);
            SkillKit.Add(_head);
            SkillKit.Add(_firstTouch);

            for (int i = 0; i < SkillKit.Count; i++)
            {
                SkillKit[i] = random.Next(randomInt, 101);
            }


        }


        public virtual bool PerformPass()
        {
            bool boolValue = PassBehavior.Pass(SkillKit);
            return boolValue;
        }
        public virtual bool PerformGoal()
        {
            bool boolValue = GoalBehavior.Goal(SkillKit);
            return boolValue;
        }
        public void SetPassBehavior(IPassBehavior passBehavior)
        {
            PassBehavior = passBehavior;
        }
        public void SetGoalBehavior(IGoalBehavior goalBehavior)
        {
            GoalBehavior = goalBehavior;
        }









    }
}
