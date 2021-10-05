using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class EspressoCoffeeMaker : CoffeeMachine
    {
        
            public override void BrewCoffee(int numOfShots)
            {
                int singleVolumeOz = 1;

                TotalShots = singleVolumeOz * numOfShots;
            }

        public override void GrindBeans(int seconds)
        {
            throw new InvalidOperationException("Espresso Coffee Maker has no grinding device.");
        }
    }
    }
