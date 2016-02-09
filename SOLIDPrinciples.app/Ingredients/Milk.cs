using System;
using SOLIDPrinciples.app.Exceptions;

namespace SOLIDPrinciples.app.Ingredients
{
    public class Milk : IConsumable
    {
        public virtual void Eat()
        {
            throw new ThisIsALiquidException();
        }

        public string GetName()
        {
            return "milk";
        }

        public virtual void Drink()
        {
            Console.WriteLine("Got milk?");
        }
    }
}