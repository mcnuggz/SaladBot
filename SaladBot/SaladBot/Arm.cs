using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladBot
{
    public abstract class Arm
    {
        public bool HaveBowl;
        public bool HaveFork;

        public abstract bool ProvideFork();
        public abstract bool ProvideBowl();
    }
}
