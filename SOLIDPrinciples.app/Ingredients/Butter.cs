using System;
using SOLIDPrinciples.app.Exceptions;

namespace SOLIDPrinciples.app.Ingredients
{
    public class Butter : Milk
    {
        public override void Eat()
        {
            Console.WriteLine("I can't believe it's not margarine!");
        }

        public override void Drink()
        {
            throw new YoullHaveToMeltMeFirst();
        }
    }
}