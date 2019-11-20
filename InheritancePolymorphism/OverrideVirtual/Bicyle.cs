using System;

namespace LearnInheritance
{
    class Bicycle : Vehicle
    {

        public Bicycle(double speed) : base(speed)
        {
            Wheels = 2;
        }

        // In the subclass, we mark the method as override, which tells the computer 
        // “I know this member is defined in the superclass, but I’d like to override it with this method”:
        // An alternative but messy solution, to override a member via NEW
        // we can define a new member with the same name
        public override void SpeedUp()
        {
            Speed += 5;

            if (Speed > 15)
            {
                Speed = 15;
            }
        }

        public override void SlowDown()
        {
            Speed -= 5;

            if (Speed < 0)
            {
                Speed = 0;
            }
        }

    }
}