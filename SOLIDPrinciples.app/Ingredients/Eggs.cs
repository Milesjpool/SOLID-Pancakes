using SOLIDPrinciples.app.Exceptions;

namespace SOLIDPrinciples.app.Ingredients
{
    public class Eggs : IConsumable
    {
        public void Eat()
        {
            throw new ThisWillGiveYouSalmonellaException();
        }

        public string GetName()
        {
            return "eggs";
        }

        public void Drink()
        {
            throw new YouCantDrinkSolidsException();
        }
    }
}