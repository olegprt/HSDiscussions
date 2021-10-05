using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public  class CoffeeMachine
    {

        public string DrinkName { get; set; }

        public int TotalShots { get; set; }
        public virtual void BrewCoffee(int numOfShots)
        {
            Console.WriteLine($"Brewing {DrinkName}.");
            int singleVolumeOz = 1;
            TotalShots = singleVolumeOz * numOfShots;
        }

        public virtual void GrindBeans(int seconds)
        {
            Console.WriteLine($"Grinding {DrinkName}.");
            Thread.Sleep(seconds);
        }
    }
}
