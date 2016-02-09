using System;
using System.Collections.Generic;
using SOLIDPrinciples.app.Cookware;
using SOLIDPrinciples.app.Ingredients;

namespace SOLIDPrinciples.app
{
    static class Jill
    {
        public static void Use(MixingBowl mixingBowl)
        {
            var ingredients = new List<IConsumable>
                {
                    new WhitePowder("flour"),
                    new WhitePowder("baking powder"),
                    new WhitePowder("salt"),
                    new WhitePowder("sugar"),
                    new Milk(),
                    new Butter(),
                    new Eggs(),
                };
            mixingBowl.Mix(ingredients);
        }
    }
}