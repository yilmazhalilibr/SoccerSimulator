using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerGame
{
    public class Football : IPlayerBehavior
    {

        public Random random = new Random();

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

        public Football(string name, int formNumber)
        {
            _name = name;
            _formNumber = formNumber;
            _speed = random.Next(50, 101);
            _durability = random.Next(80, 101);
            _pass = random.Next(65, 101);
            _shot = random.Next(45, 101);
            _ability = random.Next(55, 101);
            _stability = random.Next(55, 101);
            _inherent = random.Next(50, 101);
            _luck = random.Next(75, 101);
        }

        public virtual bool Pass()
        {
            double passPercentage = _pass * 0.3 + _ability * 0.3 + _durability * 0.1 + _inherent * 0.1 + _luck * 0.2;
            return passPercentage > 70 ? true : false;

        }

        public virtual bool GoalShot()
        {
            double goalPercentage = _ability * 0.3 + _shot * 0.2 + _stability * 0.1 + _inherent * 0.1 + _luck * 0.2;
            return goalPercentage > 59 ? true : false;
        }

    }
    class Defense : Football
    {
        private double _position;
        private double _jump;

        public Defense(string name, int formNumber) : base(name, formNumber)
        {
            _speed = random.Next(50, 101);
            _durability = random.Next(80, 101);
            _pass = random.Next(65, 101);
            _shot = random.Next(45, 101);
            _ability = random.Next(55, 101);
            _stability = random.Next(55, 101);
            _inherent = random.Next(50, 101);
            _luck = random.Next(75, 101);
            _position = random.Next(60, 101);
            _head = random.Next(30, 101);
            _jump = random.Next(45, 101);
        }
        public override bool Pass()
        {
            double passPercentage = _pass * 0.3 + _ability * 0.3 + _durability * 0.1 + _inherent * 0.1 + _position * 0.1 + _luck * 0.2;
            return passPercentage > 80 ? true : false;

        }
        public override bool GoalShot()
        {
            double goalPercentage = _ability * 0.3 + _shot * 0.2 + _stability * 0.1 + _inherent * 0.1 + _head * 0.1 + _jump * 0.1 + _luck * 0.1;
            return goalPercentage > 90 ? true : false;
        }


    }
    class Midfield : Football
    {
        private double _longshot;
        private double _productivity;
        private double _ballControl;

        public Midfield(string name, int formNumber) : base(name, formNumber)
        {
            _speed = random.Next(62, 101);
            _durability = random.Next(63, 101);
            _pass = random.Next(70, 101);
            _shot = random.Next(65, 101);
            _ability = random.Next(60, 101);
            _stability = random.Next(70, 101);
            _inherent = random.Next(65, 101);
            _luck = random.Next(60, 101);
            _longshot = random.Next(60, 101);
            _firstTouch = random.Next(60, 101);
            _productivity = random.Next(60, 101);
            _ballControl = random.Next(60, 101);
            _specialAbility = random.Next(60, 101);
        }

        public override bool Pass()
        {
            double passPercentage = _pass * 0.3 + _ability * 0.2 + _specialAbility * 0.2 + _durability * 0.1 + _inherent * 0.1 + _longshot * 0.1 + _ballControl * 0.1 + _luck * 0.1;
            return passPercentage > 76 ? true : false;

        }
        public override bool GoalShot()
        {
            double goalPercentage = _ability * 0.3 + _shot * 0.2 + _stability * 0.1 + _inherent * 0.1 + _head * 0.1 + _specialAbility * 0.2 + _luck * 0.1 + _firstTouch * 0.1;
            return goalPercentage > 72 ? true : false;
        }



    }
    class Forward : Football
    {
        private double terminate;
        private double _iceBlood;

        public Forward(string name, int formNumber) : base(name, formNumber)
        {
            _speed = random.Next(70, 101);
            _durability = random.Next(40, 101);
            _pass = random.Next(66, 101);
            _shot = random.Next(70, 101);
            _ability = random.Next(72, 101);
            _stability = random.Next(70, 101);
            _inherent = random.Next(70, 101);
            _luck = random.Next(60, 101);
            terminate = random.Next(70, 101);
            _firstTouch = random.Next(63, 101);
            _head = random.Next(70, 101);
            _specialAbility = random.Next(75, 101);
            _iceBlood = random.Next(70, 101);

        }

        public override bool Pass()
        {
            double passPercentage = _pass * 0.3 + _ability * 0.2 + _specialAbility * 0.2 + _durability * 0.1 + _inherent * 0.1 + _luck * 0.1;
            return passPercentage > 80 ? true : false;

        }
        public override bool GoalShot()
        {
            double goalPercentage = _ability * 0.2 + _shot * 0.1 + _stability * 0.1 + _inherent * 0.1 + _head * 0.1 + _specialAbility * 0.2 + _luck * 0.1 + _firstTouch * 0.1 + terminate * 0.1 + _iceBlood * 0.1;
            return goalPercentage > 85 ? true : false;
        }


    }
}
