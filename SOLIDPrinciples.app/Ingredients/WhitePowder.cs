using System;
using SOLIDPrinciples.app.Exceptions;

namespace SOLIDPrinciples.app.Ingredients
{
    public class WhitePowder : IConsumable
    {
        private readonly string _name;

        public WhitePowder(string name)
        {
            _name = name;
        }

        public void Eat()
        {
            Console.WriteLine("Mmm, yummy {0}!", _name);
        }

        public string GetName()
        {
            return _name;
        }

        public void Drink()
        {
            throw new YouCantDrinkSolidsException();
        }
    }
}