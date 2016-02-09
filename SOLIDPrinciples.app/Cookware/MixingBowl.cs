using System;
using System.Collections.Generic;
using SOLIDPrinciples.app.Ingredients;

namespace SOLIDPrinciples.app.Cookware
{
    public class MixingBowl : IWashable
    {
        private bool _isDirty;
        private readonly Dictionary<IConsumable, string> _mixture = new Dictionary<IConsumable, string>();

        public void Mix(IEnumerable<IConsumable> ingredients)
        {
            var spoon = new MixingSpoon();
            spoon.Use();
            _isDirty = true;

            foreach (var ingredient in ingredients)
            {
                switch (ingredient.GetName())
                {
                    case "milk":
                        _mixture.Add(ingredient, "250ml");
                        break;
                    case "flour":
                        _mixture.Add(ingredient, "1 cup");
                        break;
                    case "baking powder":
                        _mixture.Add(ingredient, "2 tsp");
                        break;
                    case "salt":
                        _mixture.Add(ingredient, "a pinch");
                        break;
                    case "sugar":
                        _mixture.Add(ingredient, "1 tbsp");
                        break;
                    case "eggs":
                        _mixture.Add(ingredient, "2");
                        break;
                    case "butter":
                        _mixture.Add(ingredient, "1 nob");
                        break;
                    default:
                        _mixture.Add(ingredient, "a bit");
                        break;
                }
            }

            Console.WriteLine("I have mixed my ingredients!");
        }

        public void Wear()
        {
            if (_isDirty)
                Console.WriteLine("I'm covered in mixture");
            else
                Console.WriteLine("I have a fetching new hat");
        }

        public void Wash()
        {
            _isDirty = false;
        }

        public bool IsDirty()
        {
            return _isDirty;
        }
    }
}