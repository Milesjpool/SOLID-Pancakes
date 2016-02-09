using System;
using SOLIDPrinciples.app.Cookware;

namespace SOLIDPrinciples.app
{
    static class Program
    {
        static void Main()
        {
            var mixingBowl = new MixingBowl();
            Jack.Use(mixingBowl);
            Jill.Use(mixingBowl);
            mixingBowl.Wash();
            Console.ReadLine();
        }
    }
}
