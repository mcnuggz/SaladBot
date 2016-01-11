using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaladBot
{
    public class Program
    {

        static void Main(string[] args)
        {
            Salad salad = new Salad();
            RightArm rightArm1 = new RightArm();

            rightArm1.ProvideBowl();
            rightArm1.ProvideFork();
            salad.ValidateSaladCount();

            salad.PrintSalad();
            Console.ReadLine();
        }
    }
}
