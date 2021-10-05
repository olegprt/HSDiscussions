using DemoLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            CoffeeMachine coffeeMaker = new NinjaCoffeeMaker();

            coffeeMaker.DrinkName = "Simple coffee";

            coffeeMaker.GrindBeans(1000);
            coffeeMaker.BrewCoffee(1);

            Console.WriteLine($"{ coffeeMaker.DrinkName } made { coffeeMaker.TotalShots } shots.");

            //
            //CoffeeMachine dripMaker = new DripCoffeeMaker();

            //dripMaker.DrinkName = "Americano";
            //dripMaker.GrindBeans(1000);
            //dripMaker.BrewCoffee(1);

            //Console.WriteLine($"{ dripMaker.DrinkName } made { dripMaker.TotalShots } shots.");


            ////
            //CoffeeMachine specialtyMaker = new NinjaCoffeeMaker();

            //specialtyMaker.DrinkName = "Jamaican";
            //dripMaker.GrindBeans(3000);
            //specialtyMaker.BrewCoffee(2);

            //Console.WriteLine($"{ specialtyMaker.DrinkName } made { specialtyMaker.TotalShots } shots.");



            //CoffeeMachine espressoMaker = new EspressoCoffeeMaker();

            //espressoMaker.DrinkName = "Espresso";
            //espressoMaker.GrindBeans(2000);
            //espressoMaker.BrewCoffee(1);

            //Console.WriteLine($"{ espressoMaker.DrinkName } made { espressoMaker.TotalShots } shots.");

            Console.ReadLine();
        }
    }
}
