using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DripCoffeeMaker : CoffeeMachine
    {
        public override void BrewCoffee(int numOfShots)
        {
            int singleVolumeOz = 2;
            TotalShots = singleVolumeOz * numOfShots;
        }

        public override void GrindBeans(int seconds)
        {
            Thread.Sleep(seconds);
        }
    }
}
