using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladBot
{
    public class RightArm : Arm
    {
        private int BowlCount = 0;
        private int ForkCount = 0;
        private int ForkNeeded = 1;
        private int BowlNeeded = 1;
        public override bool ProvideBowl()
        {
            if (BowlCount != BowlNeeded)
            {
                BowlCount += BowlNeeded;
                Console.WriteLine("Here's a bowl!");
            }
            return HaveBowl = true;
        }

        public override bool ProvideFork()
        {
            if (ForkCount != ForkNeeded)
            {
                ForkCount += ForkNeeded;
                Console.WriteLine("Here's a fork!");
            }
            return HaveBowl = true;
        }

    }
}
